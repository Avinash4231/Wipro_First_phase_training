var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Middleware to log incoming requests
app.Use(async (context, next) =>
{
    Console.WriteLine($"Request: {context.Request.Method} {context.Request.Path}");
    await next();
    Console.WriteLine($"Response: {context.Response.StatusCode}");
});

// Enforce HTTPS
app.UseHttpsRedirection();

// Serve static files from wwwroot
app.UseStaticFiles();

// Handle errors with a custom page
app.UseExceptionHandler("/error");

// Content Security Policy (CSP) to prevent XSS
app.Use(async (context, next) =>
{
    context.Response.Headers.Add("Content-Security-Policy", "default-src 'self'; script-src 'self'; style-src 'self'");
    await next();
});

// Error handling endpoint
app.Map("/error", () => Results.Problem("An error occurred!"));

// Default endpoint
app.Map("/", () => Results.Redirect("/index.html"));

app.Run();
