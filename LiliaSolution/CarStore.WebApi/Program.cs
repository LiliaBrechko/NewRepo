using CarStore.Application.Services;
using CarStore.Domain.Services;
using CarStore.Infrastructure.DB;
using CarStore.Presentation;
using CarStore.WebApi.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Add this to take controllers from Application project
builder.Services.AddControllers().AddApplicationPart(typeof(AssemblyReference).Assembly);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services
    .AddDomainServices()
    .AddApplicationServices()
    .AddPersistenceDependencies()
    .AddPresentation();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseMiddleware<LoggingMiddleware>();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
