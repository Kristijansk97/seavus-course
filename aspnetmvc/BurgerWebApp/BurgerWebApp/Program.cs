using Microsoft.EntityFrameworkCore;
using Business.Abstraction;
using Business.Implementation;
using DataAccess;
using DataAccess.Abstraction;
using DataAccess.Repositories;
using DomainModels;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddTransient<IBurgerService, BurgerService>();
builder.Services.AddTransient<ISizeService, SizeService>();
builder.Services.AddTransient<IMenuService, MenuService>();
builder.Services.AddTransient<IOrderService, OrderService>();
builder.Services.AddTransient<IOrderItemService, OrderItemService>();

builder.Services.AddTransient<IRepository<Burger>, BurgerRepository>();
builder.Services.AddTransient<IRepository<Order>, OrderRepository>();
builder.Services.AddTransient<IRepository<Size>, SizeRepository>();
builder.Services.AddTransient<IRepository<MenuItem>, MenuItemRepository>();
builder.Services.AddTransient<IRepository<OrderItem>, OrderItemRepository>();

builder.Services.AddDbContext<BurgerAppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("BurgerDbConnection")));

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
