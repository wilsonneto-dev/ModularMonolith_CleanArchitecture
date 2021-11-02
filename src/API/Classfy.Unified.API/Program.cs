using AutoMapper;
using Classfy.Unified.API.Configurations;
using Classfy.Unified.API.Filters;
using Classfy.Users.Application.CommandUseCases.CreateAuthor;
using Classfy.Users.Domain.Author;
using Classfy.Users.Infra.Persistence.EF.Repositories;
using FluentValidation.AspNetCore;
using MediatR;

var builder = WebApplication.CreateBuilder(args);
builder.Services
    .AddConnections(builder.Configuration)
    .AddMapper()
    .AddRepositories()
    .AddUseCases()
    .AddControllersAndConfigure()
    .AddSwaggerAndConfigure("Classfy API", "v1");

var app = builder.Build();

if (app.Environment.IsDevelopment()) app.UseSwaggerAndConfigure("Classfy API");
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
