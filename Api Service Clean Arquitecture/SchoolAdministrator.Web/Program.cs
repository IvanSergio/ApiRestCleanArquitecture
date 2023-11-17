using SchoolAdministrator.Core.Interfaces.Repositories;
using SchoolAdministrator.Core.Interfaces;
using SchoolAdministrator.Infraestructure.Data;
using SchoolAdministrator.Infraestructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);
var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork));
builder.Services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
builder.Services.AddScoped(typeof(ISchoolRepository), typeof(SchoolRepository));
builder.Services.AddScoped(typeof(IClassroomRepository), typeof(ClassroomRepository));

builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(config.GetValue<string>("ConnectionStrings:Default") ?? "",
                    x => x.MigrationsAssembly("SchoolsAdministrator.Infrastructure")));



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

