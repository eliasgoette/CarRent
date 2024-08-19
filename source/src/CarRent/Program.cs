using CarRent.Domain.Common;
using CarRent.Feature.Cars.Domain;
using CarRent.Feature.Cars.Infrastructure;
using CarRent.Persistence;
using FastEndpoints;
using FastEndpoints.Swagger;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddFastEndpoints();
builder.Services.SwaggerDocument();
builder.Services.AddDbContext<CarRentDbContext>(options =>
{
    options.UseSqlServer("Server=localhost;Database=carrent;User Id=sa;Password=Password123;Encrypt=false;");
});


builder.Services.AddScoped<ICarRepository, CarRepository>();
builder.Services.AddScoped<IUnitOfWork>(provider => provider.GetRequiredService<CarRentDbContext>());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    using var scope = app.Services.CreateScope();
    var context = scope.ServiceProvider.GetRequiredService<CarRentDbContext>();

    context.Database.EnsureDeleted();
    context.Database.EnsureCreated();

    app.UseSwaggerGen();
    app.UseSwaggerUi();
}

app.UseHttpsRedirection();
app.UseFastEndpoints();

app.Run();