namespace CrmApi.Models
{
    public class Event
    {
        public Guid Id { get; set; }
        public string Subject { get; set; } = null!;
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        // Polymorphic fields
        public Guid EntityId { get; set; }
        public string EntityType { get; set; } = null!;
    }
}
