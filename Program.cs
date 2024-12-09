using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Swag.Data;

var builder = WebApplication.CreateBuilder(args);

// Configure services
builder.Services.AddDbContext<SwagContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SwagContext") ?? throw new InvalidOperationException("Connection string 'SwagContext' not found.")));

// Add Identity
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<SwagContext>()
    .AddDefaultTokenProviders();

// Add MVC controllers with views
builder.Services.AddControllersWithViews();

// Add Razor Pages
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();  // Use authentication for login/logout
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();
