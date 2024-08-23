using Microsoft.EntityFrameworkCore;
using StudentServices.CronJobWorker;
using StudentServices.Infrastructure.Data;

var builder = Host.CreateApplicationBuilder(args);

builder
    .Services
    .AddDbContext<StudentCoursesDbContext>(options => options.UseSqlite("Data Source=database.db"));



builder.Services.AddHostedService<Worker>();

var host = builder.Build();
host.Run();
