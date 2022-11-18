using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using UserManagementWithIdentity.Data;
using UserManagementWithIdentity.Models;
using UserManagementWithIdentity.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));


builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddIdentity<ApplicationUser, IdentityRole>(opions =>
{
    opions.SignIn.RequireConfirmedAccount = true;
})
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultUI()
                .AddDefaultTokenProviders();
builder.Services.AddAuthentication().AddGoogle(options =>
{
    IConfiguration GoogleAuth = builder.Configuration.GetSection("Authentication:Google");
    options.ClientId = GoogleAuth["ClientId"];
    options.ClientSecret = GoogleAuth["ClientSecret"];

}).AddFacebook(options =>
{
    IConfiguration FaceBookAuth = builder.Configuration.GetSection("Authentication:FaceBook");
    options.AppId = FaceBookAuth["AppID"];
    options.AppSecret = FaceBookAuth["AppSecret"];

});
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IEmailSender, EmailSender>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
