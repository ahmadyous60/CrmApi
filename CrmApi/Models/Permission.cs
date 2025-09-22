namespace CrmApi.Models
{
    public class Permission
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty; // e.g., Leads.View
        public string Description { get; set; } = string.Empty;

        public ICollection<RoleAccess> RoleAccessses { get; set; } = new List<RoleAccess>();
    }
}
