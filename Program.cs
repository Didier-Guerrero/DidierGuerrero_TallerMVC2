using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using DidierGuerrero_TallerMVC2.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<DidierGuerrero_TallerMVC2Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DidierGuerrero_TallerMVC2Context") ?? throw new InvalidOperationException("Connection string 'DidierGuerrero_TallerMVC2Context' not found.")));

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
