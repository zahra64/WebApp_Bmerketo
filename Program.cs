using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebApp.Contexts;
using WebApp.Helpers.Repositories;
using WebApp.Helpers.Services;
using WebApp.Models.Entities;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

//contexts
builder.Services.AddDbContext<DataContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("Sql")));

//autentication
builder.Services.AddIdentity<UserEntity, IdentityRole>(x =>
{
    x.SignIn.RequireConfirmedAccount = false;
    x.Password.RequiredLength = 8;
    x.User.RequireUniqueEmail = true;
}).AddEntityFrameworkStores<DataContext>();


builder.Services.ConfigureApplicationCookie(x =>
{
    x.LoginPath = "/login";
    x.AccessDeniedPath = "/denied";


});

//repositories
builder.Services.AddScoped<AddressRepository>();
builder.Services.AddScoped<ProductRepository>();
builder.Services.AddScoped<ProductTagRepository>();
builder.Services.AddScoped<TagRepository>();
builder.Services.AddScoped<ContactFormRepository>();
builder.Services.AddScoped<UserAddressRepository>();




//services
builder.Services.AddScoped<AuthenticationService>();
builder.Services.AddScoped<AddressService>();
builder.Services.AddScoped<UserAdminService>();
builder.Services.AddScoped<ShowcaseService>();



var app = builder.Build();
app.UseHsts();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
