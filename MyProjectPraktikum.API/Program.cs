using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MyProjectPraktikum.Context;
using MyProjectPraktikum.Repository.Interface;
using MyProjectPraktikum.Repository.Repositories;
using MyProjectPraktikum.Services;
using MyProjectPraktikum.Services.Interfaces;
using MyProjectPraktikum.Services.Services;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.


// Add services to the container.

builder.Services.AddCors(opt => opt.AddPolicy("PolicyName", policy =>
{
    policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
}));


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddServices();
builder.Services.AddDbContext<IContext, MyDBContext>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("PolicyName");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
