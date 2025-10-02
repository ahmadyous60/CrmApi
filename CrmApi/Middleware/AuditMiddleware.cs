using CrmApi.Data;
using CrmApi.Models;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using System.Text.Json;

public class AuditMiddleware
{
    private readonly RequestDelegate _next;

    public AuditMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async System.Threading.Tasks.Task InvokeAsync(HttpContext context, CrmDbContext db)
    {
        var request = context.Request;

       
        var userId = context.User.FindFirstValue(ClaimTypes.NameIdentifier);
        var userName = context.User.Identity?.Name;

        
        string? bodyContent = null;
        if (request.Method != HttpMethods.Get && request.ContentLength > 0)
        {
            request.EnableBuffering(); 
            using var reader = new StreamReader(request.Body, leaveOpen: true);
            bodyContent = await reader.ReadToEndAsync();
            request.Body.Position = 0; // reset for next middleware
        }

        await _next(context);

        // Log only API calls
        if (request.Path.StartsWithSegments("/api"))
        {
            var log = new AuditLog
            {
                UserId = userId,
                UserName = userName,
                Action = request.Method,
                Endpoint = request.Path,
                QueryString = request.QueryString.HasValue ? request.QueryString.Value : null,
                RequestBody = bodyContent,
                IpAddress = context.Connection.RemoteIpAddress?.ToString(),
                Timestamp = DateTime.UtcNow
            };

            db.AuditLogs.Add(log);
            await db.SaveChangesAsync();
        }
    }
}
