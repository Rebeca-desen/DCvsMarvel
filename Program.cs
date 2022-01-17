using Microsoft.Extensions.Options;
using projectC.Models;
using projectC.Services;

var builder = WebApplication.CreateBuilder(args);
 // requires using Microsoft.Extensions.Options
  
    builder.Services.Configure<HeroistoreDatabaseSettings>(
    builder.Configuration.GetSection("HeroistoreDatabaseSettings"));

    builder.Services.AddSingleton<IHeroistoreDatabaseSettings>(sp =>
        sp.GetRequiredService<IOptions<HeroistoreDatabaseSettings>>().Value);

    builder.Services.AddSingleton<HeroisServices>();


builder.Services.Configure<ViloestoreDatabaseSettings>(
    builder.Configuration.GetSection("ViloestoreDatabaseSettings"));

    builder.Services.AddSingleton<IViloestoreDatabaseSettings>(sp =>
        sp.GetRequiredService<IOptions<ViloestoreDatabaseSettings>>().Value);

    builder.Services.AddSingleton<ViloesServices>();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
