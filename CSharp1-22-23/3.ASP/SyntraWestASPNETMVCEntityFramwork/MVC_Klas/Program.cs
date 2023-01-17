using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MVC_Klas.Models;
using MVC_Klas.Services;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using MVC_Klas.Interface;

var builder = WebApplication.CreateBuilder(args);

//Add database connection
var configBuilder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
var config = configBuilder.Build();
builder.Services.AddDbContext<KlasContext>(options => options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

// Add services to the container.
builder.Services.AddControllersWithViews();

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

app.Run();
