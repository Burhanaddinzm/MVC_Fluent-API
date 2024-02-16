using Microsoft.EntityFrameworkCore;
using WebApplication1.Models.Contexts;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<DataContext>(cfg => cfg.UseSqlServer(
builder.Configuration.GetConnectionString("cString"), option =>
{
    option.MigrationsHistoryTable("Migrations");
}
));
var app = builder.Build();


app.UseStaticFiles();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
