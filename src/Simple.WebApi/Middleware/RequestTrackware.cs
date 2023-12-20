namespace Simple.WebApi.Middleware;

public class RequestTrackware
{
    private readonly RequestDelegate _next;

    public RequestTrackware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        context.Items.Add("RequestId", Guid.NewGuid());
        await _next(context);
    }
}

public static class RequestTrackwareExtensions
{
    public static IApplicationBuilder UseRequestTrackware(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<RequestTrackware>();
    }
}