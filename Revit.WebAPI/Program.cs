using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Revit.Entity.Commons;
using Revit.Entity.Roles;
using Revit.Entity.Users;
using Revit.EntityFrameworkCore;
using Revit.Repository;
using Revit.Repository.Commons;
using Revit.WebAPI.Extension;
using Swashbuckle.AspNetCore.Filters;
using System.IdentityModel.Tokens.Jwt;
using System.Reflection;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

builder.AddRevitController();

builder.AddRevitDbContext();


builder.AddRevitJWT();
//Identity注入，添加数据库上下文
builder.AddRevitRepository();
builder.AddRevitUnitOfWork();

builder.AddRevitAutoMapper();
//swagger
builder.AddRevitSwaggerGen();

var origins=builder.AddRevitCorsOrigins();


var app = builder.Build();

app.UseCors(origins);
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
