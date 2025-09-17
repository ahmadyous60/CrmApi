using Microsoft.AspNetCore.Authorization;

namespace CrmApi.Authorization
{
    // Requirement: tells which permission is required
    public class PermissionRequirement : IAuthorizationRequirement
    {
        public string Permission { get; }

        public PermissionRequirement(string permission)
        {
            Permission = permission;
        }
    }
}
