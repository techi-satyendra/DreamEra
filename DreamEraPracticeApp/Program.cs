var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "You have done it,you are a genious.");

app.Run();
