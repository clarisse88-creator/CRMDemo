

namespace API.Middleware;

public class ApiKeyMiddleWare
{
    private readonly string ApiKeyHeader= "X-Api-Key";
    private const string ApiKeyconfigKey = "ApiSettings:ApiKey";

   private readonly RequestDelegate _next;
   private readonly string _apiKey;

    public ApiKeyMiddleWare(RequestDelegate next, IConfiguration configuration)
    {
        _next = next;
        _apiKey = configuration[ApiKeyconfigKey]
        ?? throw new InvalidOperationException($"API Key not found in configuration.set: '{ApiKeyconfigKey}'");
    }

    public async Task InvokeAsync(HttpContext context)
    {
        if (!context.Request.Headers.TryGetValue(ApiKeyHeader, out var providedKey)||
            !string.Equals(providedKey, _apiKey, StringComparison.Ordinal))
        {
            context.Response.StatusCode = StatusCodes.Status401Unauthorized; // Unauthorized
            await context.Response.WriteAsJsonAsync(new { error = "API Key is missing or invalid." });
            return;
        }
        await _next(context);
    }
}