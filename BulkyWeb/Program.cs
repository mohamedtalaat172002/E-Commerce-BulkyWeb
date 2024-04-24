using Bulky.DataAccess.Data;
using Bulky.DataAccess.RepositoryBase.IRepository;
using Bulky.DataAccess.RepositoryBase.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ApplicationDbContext>(opt => opt.UseSqlServer(
    builder.Configuration.GetConnectionString("DefaultConnection")
    ));

//register user classes services 
builder.Services.AddScoped<IUniteOfWork, UniteOfWork>();
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
    pattern: "{area=Admin}/{controller=Category}/{action=Index}/{id?}");

app.Run();
