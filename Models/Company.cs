namespace CrmApi.Models
{
    public class Company
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
        public string? Industry { get; set; }
        public string? Website { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
