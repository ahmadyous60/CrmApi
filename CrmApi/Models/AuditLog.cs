namespace CrmApi.Models
{
    public class AuditLog
    {
        public Guid Id { get; set; }

        // User Info
        public string? UserId { get; set; }
        public string? UserName { get; set; }

        // Request Info
        public string Action { get; set; } = string.Empty; // GET, POST, PUT, DELETE
        public string Endpoint { get; set; } = string.Empty; // /api/lead/create

        public string? QueryString { get; set; }
        public string? RequestBody { get; set; }

        public string? IpAddress { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
    }
}
