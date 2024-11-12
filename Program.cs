using fistproject.Dtos;
using fistproject.Endpoint;
using fistproject.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Retrieve the connection string from appsettings.json
var connString = builder.Configuration.GetConnectionString("GameStore");

// Register the DbContext with SQLite using the connection string
builder.Services.AddDbContext<GameStoreContext>(options =>
    options.UseSqlite(connString));

var app = builder.Build();

// Map endpoints
app.MapsGameEndpoints();
app.MigrateDatabase();
app.MapGet("/", () => "Hello World!");

app.Run();
