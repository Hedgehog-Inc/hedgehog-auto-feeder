
using PartsUnlimited.Web;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => $"{ProjectInfo.GetTitle()} - YAML CD Updated");
app.MapGet("/health", () => Results.Ok("Healthy"));

app.Run();
