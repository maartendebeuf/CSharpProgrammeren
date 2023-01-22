using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MVC_Klas.Models;
using MVC_Klas.Services;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using MVC_Klas.Interface;
using Microsoft.AspNetCore.Localization;
using System.Globalization;
using Microsoft.AspNetCore.HttpLogging;
using Serilog;
using System.Reflection;
using System.Diagnostics;

var builder = WebApplication.CreateBuilder(args);

//Add database connection
var configBuilder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
var config = configBuilder.Build();
builder.Services.AddDbContext<KlasContext>(options => options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

builder.Services.AddLocalization(options => options.ResourcesPath = "Localization");

// Add services to the container.
builder.Services.AddControllersWithViews()
                .AddViewLocalization(Microsoft.AspNetCore.Mvc.Razor.LanguageViewLocationExpanderFormat.SubFolder)
                .AddDataAnnotationsLocalization();

// Add logging
builder.Services.AddHttpLogging(logging =>
{
    logging.LoggingFields = HttpLoggingFields.All;
    logging.RequestHeaders.Add("sec-ch-ua");
    logging.RequestHeaders.Add("Cookie");
    logging.ResponseHeaders.Add("MyResponseHeader");
    logging.MediaTypeOptions.AddText("application/javascript");
    logging.RequestBodyLogLimit = 4096;
    logging.ResponseBodyLogLimit = 4096;
});

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Debug()
    .WriteTo.File($"c:/temp/Logs/{Assembly.GetExecutingAssembly().GetName().Name}.log")
    .CreateLogger();
builder.Logging.ClearProviders();
builder.Logging.AddSerilog();

builder.Services.AddTransient<JsonDierenartsService>();
builder.Services.AddTransient<FamilieRepository>();

#if DEBUGINMEM

builder.Services.AddTransient<IKlasseRepository, KlasseRepositoryInMem>();

#else

builder.Services.AddTransient<IKlasseRepository, KlasseRepository>();

#endif

builder.Services.AddTransient<OrdeRepository>();
builder.Services.AddTransient<DierRepository>();

builder.Services.AddDistributedMemoryCache();

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromSeconds(10);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

var app = builder.Build();

app.UseHttpLogging();

app.MapWhen(context => context.Request.Query.ContainsKey("branch"), HandleBranch);

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseSession();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.UseRequestLocalization(options =>
{
    options.DefaultRequestCulture = new RequestCulture("nl");
    options.SupportedCultures = new List<CultureInfo> { new CultureInfo("nl"), new CultureInfo("en"), new CultureInfo("fr") };
});


//app.Run(async context =>
//{
//    await context.Response.WriteAsync("<h2>Hello Middleware!</h2>");
//});

app.Map("/map1", HandleMapTest1);
app.Map("/map2", HandleMapTest2);

//app.Use(async (context, next) =>
//{
//    await context.Response.WriteAsync("<h2>Hello Middleware!</h2>");
//    await next.Invoke();
//});

//app.Use(async (context, next) =>
//{
//    // Do work that can write to the Response.
//    await next.Invoke();
//    // Do logging or other work that doesn't write to the Response.
//});

app.Use((context, next) =>
{
    // Voer een specifieke actie uit voordat de volgende middleware aangeroepen wordt
    context.Response.Headers.Add("X-Example-Header", "Example Value");
    // Roep de volgende middleware aan
    return next(context);
});

app.Use(async (context, next) =>
{
    var stopwatch = Stopwatch.StartNew();
    var request = context.Request;

    // Log de aanvraag
    Debug.WriteLine($"{request.Method} {request.Path} {request.QueryString}");

    // Roep de volgende middleware aan
    await next(context);

    // Log de responsetijd
    stopwatch.Stop();
    Debug.WriteLine($"Response time: {stopwatch.ElapsedMilliseconds} ms");

});

//Controle op API key
//app.Use(async (context, next) =>
//{
//    var request = context.Request;
//    var apiKey = request.Headers["ApiKey"];

//    if (apiKey != "mysecretkey")
//    {
//        context.Response.StatusCode = 401; // Unauthorized
//        return;
//    }

//    await next(context);
//});

app.Use((context, next) => {
    //var value = context.Request.Cookies["cookie"];
    var culture = CultureInfo.CurrentCulture;
    //var culture = new CultureInfo(value);

    Thread.CurrentThread.CurrentCulture = culture;
    Thread.CurrentThread.CurrentUICulture = culture;
    return next();
});

app.Run();

static void HandleMapTest1(IApplicationBuilder app)
{
    app.Run(async context =>
    {
        await context.Response.WriteAsync("Mapping test from 1");
    });
}

static void HandleMapTest2(IApplicationBuilder app)
{
    app.Run(async context =>
    {
        await context.Response.WriteAsync("Mapping test from 2");
    });
}

static void HandleBranch(IApplicationBuilder app)
{
    app.Run(async context =>
    {
        var branchVer = context.Request.Query["branch"];
        await context.Response.WriteAsync($"Branch used = {branchVer}");
    });
}