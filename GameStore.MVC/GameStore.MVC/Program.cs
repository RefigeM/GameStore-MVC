using GameStore.BL.Services.Abstractions;
using GameStore.BL.Services.Concretes;
using GameStore.DAL.Contexts;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

string connectionStr = builder.Configuration.GetConnectionString("refige");

builder.Services.AddDbContext<GameStoreDbContext>(opt =>
{
opt.UseSqlServer(connectionStr);
});
builder.Services.AddScoped<ITrendingGamesService, TrendingGamesService>();
var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();
app.UseEndpoints(endpoints =>
{
	endpoints.MapControllerRoute(
	  name: "areas",
	  pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}"
	);
});
app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();
