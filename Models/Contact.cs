namespace CrmApi.Models
{
    public class Contact
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? Mobile { get; set; }
        public DateTime? Dob { get; set; }
        public string? ReportingTo { get; set; }
        public string? MailingStreet { get; set; }
        public string? OtherStreet { get; set; }
        public string? MailingCity { get; set; }
        public string? OtherCity { get; set; }
        public string? MailingState { get; set; }
        public string? OtherState { get; set; }
        public string? MailingZip { get; set; }
        public string? MailingCountry { get; set; }
        public Guid? CompanyId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
