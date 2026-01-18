namespace CrmApi.Models
{
    public class RequestAuditLog
    {
        public Guid Id { get; set; }
        public string? UserId { get; set; }
        public string? UserName { get; set; }
        public string HttpMethod { get; set; } = string.Empty; // GET / POST / PUT
        public string Url { get; set; } = string.Empty;
        public string? RequestBody { get; set; }
        public string? IpAddress { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
    }
}
