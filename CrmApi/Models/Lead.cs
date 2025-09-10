namespace CrmApi.Models
{
    public class Lead
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string Phone { get; set; } = default!;

        // "New" | "Qualified" | "Won" | "Lost"
        public string Status { get; set; } = "New";

        // "Website" | "Referral" | "Email" | "Cold Call"
        public string Source { get; set; } = "Website";

        // Dropdown for category
        public string ProductCategory { get; set; } = "Software";

        // Dropdown for product under selected category
        public string Product { get; set; } = "Software License";

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
