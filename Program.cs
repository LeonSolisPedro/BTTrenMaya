using Microsoft.EntityFrameworkCore;
using signalR101;
using signalR101.Interfaces;
using signalR101.Models;
using signalR101.Repositories;

// Add services to the container.
var builder = WebApplication.CreateBuilder(args);
builder.Services.Configure<CookiePolicyOptions>(options =>
{
  options.CheckConsentNeeded = context => true;
  options.MinimumSameSitePolicy = SameSiteMode.None;
});
builder.Services.AddTransient<IProductRepository, ProductRepository>();
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddSignalR();
builder.Services.AddHttpClient().AddControllersWithViews();


var app = builder.Build();
if (!app.Environment.IsDevelopment())
{
  app.UseExceptionHandler("/Home/Error");
  // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
  app.UseHsts();
}
app.UseRouting();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseCookiePolicy();
app.MapControllerRoute("default", "{controller=Home}/{action=Index}");
app.MapHub<SignalServer>("/signalServer");
app.Run();
