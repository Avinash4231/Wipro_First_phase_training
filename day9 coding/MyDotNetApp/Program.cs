using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.UseHttpsRedirection();

        // Middleware to log requests and responses
        app.Use(async (context, next) =>
        {
            // Log the request
            Console.WriteLine($"Incoming request: {context.Request.Method} {context.Request.Path}");
            
            // Call the next middleware
            await next();

            // Log the response
            Console.WriteLine($"Outgoing response: {context.Response.StatusCode}");
        });

        // Middleware to handle errors and return custom error page
        app.Use(async (context, next) =>
        {
            try
            {
                await next();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unhandled exception: {ex.Message}");
                context.Response.Redirect("/error.html");
            }
        });

        app.UseStaticFiles();

        // Middleware to add security headers
        app.Use(async (context, next) =>
        {
            context.Response.Headers.Add("Content-Security-Policy", "default-src 'self'");
            await next();
        });

        app.Run(async (context) =>
        {
            await context.Response.WriteAsync("Hello World!");
        });
    }
}
