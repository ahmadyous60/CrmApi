using Microsoft.AspNetCore.Identity;

namespace CrmApi.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; } = null!;
    }
}
