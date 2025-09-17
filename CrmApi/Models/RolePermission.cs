using Microsoft.AspNetCore.Identity;
using System.Security;

namespace CrmApi.Models
{
    public class RolePermission
    {
        public Guid Id { get; set; }

        public string RoleId { get; set; } = string.Empty;
        public Guid PermissionId { get; set; }

        public IdentityRole Role { get; set; } = null!;
        public Permission Permission { get; set; } = null!;
    }
}
