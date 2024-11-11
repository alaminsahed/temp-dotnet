using fistproject.Dtos;
using fistproject.Endpoint;
using fistproject.Data;

var builder = WebApplication.CreateBuilder(args);
var connString = builder.Configuration.GetConnectionString("GameStore");
builder.Services.AddSqlite<GameStoreContext>(connString);

var app = builder.Build();

app.MapsGameEndpoints();
app.MapGet("/", () => "Hello World!");

app.Run();
