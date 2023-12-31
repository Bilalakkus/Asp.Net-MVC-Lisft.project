using Admin.project.Contexts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<LiftContext>(o =>
        o.UseSqlServer(builder.Configuration.GetConnectionString("default")));
//builder.Services.AddDbContext<LiftContext>(opt =>
//    opt.UseSqlServer("Server=.\\BILALAKKUS;Database=LiftDB;Integrated Security=True;TrustServerCertificate=true;User ID=sa;Password=a1234*"));

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
