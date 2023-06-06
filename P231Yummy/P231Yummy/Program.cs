using Microsoft.EntityFrameworkCore;
using P231Yummy.DAL;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<YummyDbContext>(opt =>
{
    opt.UseSqlServer("Server=DESKTOP-BU4GQ1K\\SQLEXPRESS;Database=P231Yummy;Trusted_Connection=True");
});

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
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
