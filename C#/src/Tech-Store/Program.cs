//We setup the builder that will encompass service registration as well as various app setup
using Microsoft.EntityFrameworkCore;
using Tech_Store.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<TechStoreContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

//Assists us load images from the www folder
app.MapStaticAssets();

//This would be the default route
app.MapControllerRoute(
    name: "default",
    //the controller, the action the optional id
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

//starts the application and begins listening for http requests
app.Run();
