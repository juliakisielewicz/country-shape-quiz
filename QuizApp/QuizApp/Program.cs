﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using QuizApp.Data;
using QuizApp.Models;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<QuizAppContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("QuizAppContext") ?? throw new InvalidOperationException("Connection string 'QuizAppContext' not found.")));

builder.Services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<QuizAppContext>();

builder.Services.ConfigureApplicationCookie(config =>
{
    config.LoginPath = "/Login";
});

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<QuizAppContext>();
    context.Database.EnsureCreated();
    SeedData.Initialize(services);
}


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
