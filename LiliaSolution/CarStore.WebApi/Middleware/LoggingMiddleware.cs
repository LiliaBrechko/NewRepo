using System.Diagnostics;

namespace CarStore.WebApi.Middleware;

public class LoggingMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<LoggingMiddleware> _logger;

    public LoggingMiddleware(RequestDelegate next, ILogger<LoggingMiddleware> logger)
    {
        _next = next;
        _logger = logger;
    }

    public async Task Invoke(HttpContext context)
    {
        // Log the incoming request
        _logger.LogInformation($"Incoming Request: {context.Request.Method} {context.Request.Path}");

        // Start a timer to measure request duration
        var stopwatch = Stopwatch.StartNew();

        try
        {
            // Proceed to the next middleware in the pipeline
            await _next(context);

            // Log the outgoing response
            _logger.LogInformation(
                $"Outgoing Response: {context.Response.StatusCode} - {stopwatch.ElapsedMilliseconds}ms");
        }
        catch (Exception ex)
        {
            // Log exceptions
            _logger.LogError(ex, $"An error occurred while processing the request: {ex.Message}");
            throw;
        }
    }
}