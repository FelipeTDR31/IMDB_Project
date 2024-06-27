using backend.Routes;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapMovieRoutes();

app.Run();
