using Microsoft.EntityFrameworkCore;
using CarRent.Feature.Cars.Domain;
using CarRent.Feature.Cars.Infrastructure;
using CarRent.Persistence;
using FastEndpoints;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<CarRentDbContext>(options =>
{
    options.UseSqlServer("Server=localhost;Database=carrent;User Id=sa;Password=Password123;Encrypt=false;");
});


builder.Services.AddScoped<ICarRepository, CarRepository>();
builder.Services.AddFastEndpoints();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    using var scope = app.Services.CreateScope();
    var context = scope.ServiceProvider.GetRequiredService<CarRentDbContext>();

    context.Database.EnsureDeleted();
    context.Database.EnsureCreated();

    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseFastEndpoints();

app.Run();