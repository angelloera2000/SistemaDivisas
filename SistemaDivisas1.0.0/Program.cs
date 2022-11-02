using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SistemaDivisas1._0._0.Areas.Identity.Data;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("SistemasDivisasDbContextConnection") ?? throw new InvalidOperationException("Connection string 'SistemasDivisasDbContextConnection' not found.");

builder.Services.AddDbContext<SistemasDivisasDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<SistemaDivisasUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<SistemasDivisasDbContext>();

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
app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();
app.Run();
