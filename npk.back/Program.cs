using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NLog;
using NLog.Web;
using npk.back.EFCore;
using npk.back.Repositories.Persons;
using System;

var logger = NLog.LogManager.Setup().LoadConfigurationFromAppSettings().GetCurrentClassLogger();
try
{
  var builder = WebApplication.CreateBuilder(args);

  builder.Services.AddControllers();
  // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
  builder.Services.AddEndpointsApiExplorer();
  builder.Services.AddSwaggerGen();
  builder.Services.AddDbContext<PersonsDbContext>(x => x.UseInMemoryDatabase(databaseName: "PersonsDb"));

  builder.Services.AddScoped<IPersonsRepo, PersonsRepo>();

  builder.Services.AddCors();
  var app = builder.Build();
  //------------------------------------------------------------------------
  if (app.Environment.IsDevelopment())
  {
    app.UseSwagger();
    app.UseSwaggerUI();
  }

  app.UseHttpsRedirection();
  if (app.Environment.IsDevelopment())
  {
    app.UseCors(x =>
    {
      x.AllowAnyHeader();
      x.AllowAnyMethod();
      x.AllowAnyOrigin();
    });
  }
  app.MapControllers();

  app.Run();
}
catch (Exception ex)
{
  logger.Error(ex, "Stopped program because of exception");
  throw;
}
finally
{
  NLog.LogManager.Shutdown();
}