using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Fall2024_Assignment3_dltsao.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
<<<<<<< Updated upstream
builder.Services.AddControllersWithViews();
=======
builder.Services.AddRazorPages();
>>>>>>> Stashed changes

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
<<<<<<< Updated upstream
{
    app.UseMigrationsEndPoint();
}
else
=======
>>>>>>> Stashed changes
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

<<<<<<< Updated upstream
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
=======
>>>>>>> Stashed changes
app.MapRazorPages();

app.Run();
