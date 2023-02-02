using HelloCoreMVC33.DataLayer;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddDbContext<EmployeeContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
//var ConnectionString = builder.Configuration.GetConnectionString("DefaultConnection");
//builder.Services.AddDbContext<EmployeeContext>(options => options.UseSqlServer(ConnectionString));
builder.Services.AddDbContext<EmployeeContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
