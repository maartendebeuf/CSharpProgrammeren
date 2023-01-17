using MVC_Klas.Interfaces;
using MVC_Klas.Models;
using MVC_Klas.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<JsonDierenartsService>();
builder.Services.AddTransient<IFamilieRepository, FamilieRepository>();
builder.Services.AddTransient<KlasseRepository>();
builder.Services.AddTransient<OrdeRepository>();
builder.Services.AddTransient<IDierRepository, DierRepository>();//transient zie laatste file
                                                                 // ook eens checken waar remove zit in begin van view voor disposen familieobject

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
