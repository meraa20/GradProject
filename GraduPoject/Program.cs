using GraduPoject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddResponseCaching();

builder.Services.AddDbContext<DbContexxt>(op =>
{
    op.UseSqlServer(builder.Configuration.GetConnectionString("cs"));
}

);
builder.Services.AddIdentity<IdUser, IdentityRole>(op =>
{
    op.Password.RequireUppercase=true;
    op.Password.RequireLowercase=true;
    op.Password.RequireDigit=true;
    op.Password.RequiredLength=6;
    op.Password.RequireNonAlphanumeric=false;

}).AddEntityFrameworkStores<DbContexxt>().AddDefaultTokenProviders();


var app = builder.Build();
app.UseResponseCaching();

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

var scope=app.Services.CreateScope();
var roleMang=scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
 if (roleMang.Roles.Count() == 0)
{
    var rols= new List<IdentityRole>
    {
        new IdentityRole("Admin"),
        new IdentityRole("BusinessOwner"),
        new IdentityRole("User")
    };
    foreach(var ro in rols)
    {
        roleMang.CreateAsync(ro).Wait();
    }
}

app.Run();
