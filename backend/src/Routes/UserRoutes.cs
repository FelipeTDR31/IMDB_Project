namespace backend.Routes;

public static class UserRoutes
{
    public static IEndpointRouteBuilder MapUserRoutes(this IEndpointRouteBuilder app)
    {
        app.MapGet("/users", () => "Hello World!");
        return app;
    }
}