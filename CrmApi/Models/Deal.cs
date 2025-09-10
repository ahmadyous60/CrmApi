namespace CrmApi.Models
{
    public class Deal
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = default!;
        public decimal Amount { get; set; }
        // "Prospecting" | "Proposal" | "Negotiation" | "Closed Won" | "Closed Lost"
        public string Stage { get; set; } = "Prospecting";
        public DateTime? CloseDate { get; set; }
        public Guid? ContactId { get; set; }
        public Guid? CompanyId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
