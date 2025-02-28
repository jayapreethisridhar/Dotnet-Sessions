using CachingMiddlewares.Caches;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

// Add caching middleware
app.UseMiddleware<CacheMiddle>();

// Other configurations...

app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapGet("/hello", () => "Hello World!");
    endpoints.MapGet("/goodbye", () => "Goodbye World!");
    endpoints.MapGet("/foo", () => "Foo Bar!");
});

app.Run();
