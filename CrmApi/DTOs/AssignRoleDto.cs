namespace CrmApi.DTOs
{
    public class AssignRoleDto
    {
        public Guid UserId { get; set; } 
        public string Role { get; set; } = string.Empty;
    }
}
