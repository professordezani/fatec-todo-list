using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddDbContext<DatabaseContext>(opt => opt.UseInMemoryDatabase("db"));

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.MapControllerRoute("default", "{controller=Todo}/{action=Index}/{id?}");

app.Run();
