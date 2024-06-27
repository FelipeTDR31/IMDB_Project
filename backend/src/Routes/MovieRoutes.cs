namespace backend.Routes;

public static class MovieRoutes
{
    public static IEndpointRouteBuilder MapMovieRoutes(this IEndpointRouteBuilder app)
    {
        app.MapGet("/movies", () => "Hello World!");
        return app;
    }
}