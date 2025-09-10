namespace CrmApi.Models
{
    public class Contact
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string? Phone { get; set; }
        public Guid? CompanyId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
