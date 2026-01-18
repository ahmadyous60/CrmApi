namespace CrmApi.Models
{
    public class Task
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; }

        // Polymorphic fields
        public Guid EntityId { get; set; }        
        public string EntityType { get; set; } = null!; 
    }
}
