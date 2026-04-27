using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

string connStr = "Server=localhost\\SQLEXPRESS;Database=BDTodo;Trusted_Connection=True;TrustServerCertificate=True";
// "...;User Id=aluno; Password=dba; ...

builder.Services
    .AddDbContext<DatabaseContext>(opt => opt.UseSqlServer(connStr));

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.MapControllerRoute("default", "{controller=Todo}/{action=Index}/{id?}");

app.Run();
