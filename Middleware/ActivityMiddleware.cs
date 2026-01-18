using CrmApi.Data;
using CrmApi.Models;
using CrmApi.Services;
using Microsoft.AspNetCore.Http;
using System.Text;

namespace CrmApi.Middleware
{
    public class ActivityMiddleware
    {
        private readonly RequestDelegate _next;

        public ActivityMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async System.Threading.Tasks.Task InvokeAsync(HttpContext context, CrmDbContext dbContext, ICurrentUserService currentUser)
        {
            // Skip static files and Swagger
            var path = context.Request.Path.Value ?? string.Empty;
            if (path.Contains("swagger") || path.Contains("health") || path.Contains("_framework"))
            {
                await _next(context);
                return;
            }

            // Only log non-GET requests
            if (context.Request.Method != HttpMethods.Get)
            {
                string? requestBody = null;

                // Enable request body reading
                context.Request.EnableBuffering();
                if (context.Request.ContentLength > 0 && context.Request.Body.CanRead)
                {
                    using var reader = new StreamReader(
                        context.Request.Body,
                        encoding: Encoding.UTF8,
                        detectEncodingFromByteOrderMarks: false,
                        bufferSize: 1024,
                        leaveOpen: true);

                    requestBody = await reader.ReadToEndAsync();
                    context.Request.Body.Position = 0; // Reset stream
                }

                var auditLog = new RequestAuditLog
                {
                    Id = Guid.NewGuid(),
                    UserId = currentUser.UserId ?? "System",
                    UserName = currentUser.UserName ?? "System",
                    HttpMethod = context.Request.Method,
                    Url = path,
                    RequestBody = requestBody,
                    IpAddress = context.Connection.RemoteIpAddress?.ToString(),
                    Timestamp = DateTime.UtcNow
                };

                dbContext.RequestAuditLogs.Add(auditLog);
                await dbContext.SaveChangesAsync();
            }

            // Call the next middleware
            await _next(context);
        }
    }

    // Extension method to register middleware
    public static class ActivityMiddlewareExtensions
    {
        public static IApplicationBuilder UseActivityLogging(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ActivityMiddleware>();
        }
    }
}
