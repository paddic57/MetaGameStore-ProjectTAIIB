using BusinessLayer;
using IBusinessLayer;
using IRepositories;
using Microsoft.EntityFrameworkCore;
using Models;
using Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<MyContext>(
        a => a.UseNpgsql(builder.Configuration.GetConnectionString("MyDatabase"))
);
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IProduct, BLProduct>();
builder.Services.AddScoped<IUser, BLUser>();
builder.Services.AddScoped<IOrder, BLOrder>();
builder.Services.AddScoped<IOrderDetails, BLOrderDetails>();
builder.Services.AddScoped<IPayment, BLPayment>();
builder.Services.AddScoped<IProductGame, BLProductGame>();


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
