using Microsoft.EntityFrameworkCore;
using Day3_02.Models;
using Day3_02.Repositries;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);


var log4netRepository = log4net.LogManager.GetRepository(Assembly.GetEntryAssembly());
log4net.Config.XmlConfigurator.Configure(log4netRepository, new FileInfo("log4net.config"));
builder.Logging.AddLog4Net();

builder.Services.AddDbContext<EmployeeDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("EmployeeDbContext"))); ;

builder.Services.AddTransient<IEmployeeRepos, EmployeeRepos>();

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
    pattern: "{controller=Employee}/{action=Index}/{id?}");

app.Run();