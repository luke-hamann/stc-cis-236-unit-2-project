//
// Title: Program.cs
// Purpose: This file configures, builds, and runs the application. This
//          includes configuring dependency injection of the whale database
//          context, enabling lowercase urls with trailing slashes, and
//          configuring routing to use url slugs.
//

using Microsoft.EntityFrameworkCore;
using WhaleApp.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<WhaleContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("WhaleContext")));

builder.Services.AddRouting(options =>
{
    options.LowercaseUrls = true;
    options.AppendTrailingSlash = true;
});

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
    pattern: "{controller=Home}/{action=Index}/{id?}/{slug?}");

app.Run();
