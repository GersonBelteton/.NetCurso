
using Microsoft.EntityFrameworkCore;
using practica.Models;

var builder = WebApplication.CreateBuilder(args);

// sql server connection 


builder.Services.AddDbContext<EmpleadoCTX>(options => {
    var config = builder.Configuration;
    var connectionString = config.GetConnectionString("WebApiDatabase");
    
    options.UseSqlServer(connectionString);
});

// var connection = @"Data Source=localhost; Initial Catalog=dbEmpleado; User Id=sa; Password=1234";

// builder.Services.AddDbContext<EmpleadoCTX>(options => options.UseSqlServer(
// builder.Configuration.GetConnectionString(connection)
// ));
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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
