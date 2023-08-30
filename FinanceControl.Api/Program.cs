using FinanceControl.Api.Data;
using FinanceControl.Api.Models;
using FinanceControl.Api.Services;
using FinanceControl.Api.Services.IServices;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<FCDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("FCDbContext"));
});

builder.Services.AddIdentity<AppUser, IdentityRole>()
    .AddEntityFrameworkStores<FCDbContext>()
    .AddDefaultTokenProviders();

builder.Services.AddScoped<ICartaoService, CartaoService>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
