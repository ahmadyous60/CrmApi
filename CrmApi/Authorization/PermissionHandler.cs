using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace CrmApi.Authorization
{
    // Handler: checks if the user has the required permission claim
    public class PermissionHandler : AuthorizationHandler<PermissionRequirement>
    {
        protected override Task HandleRequirementAsync(
            AuthorizationHandlerContext context,
            PermissionRequirement requirement)
        {
            // Check if the JWT has "permission" claim with the required value
            if (context.User.HasClaim(c =>
                c.Type == "permission" &&
                c.Value == requirement.Permission))
            {
                context.Succeed(requirement); // ✅ Permission granted
            }

            return Task.CompletedTask;
        }
    }
}
