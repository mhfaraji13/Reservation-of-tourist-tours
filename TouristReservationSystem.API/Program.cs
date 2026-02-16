using Microsoft.EntityFrameworkCore;
using TouristReservationSystem.Infrastructure.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


var connectionString = builder.Configuration.GetConnectionString("TouristReservationConnectionString");

builder.Services.AddDbContext<TouristReservationDbContext>(options =>
    options.UseSqlServer(connectionString , 
        b =>b.MigrationsAssembly("TouristReservationSystem.Infrastructure")));


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