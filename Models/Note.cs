namespace CrmApi.Models
{
    public class Note
    {
        public Guid Id { get; set; }
        public string Content { get; set; } = null!;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Polymorphic fields
        public Guid EntityId { get; set; }
        public string EntityType { get; set; } = null!;
    }
}
