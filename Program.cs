using fistproject.Dtos;
using fistproject.Endpoint;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapsGameEndpoints();
app.MapGet("/", () => "Hello World!");

app.Run();
