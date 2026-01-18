namespace CrmApi.Models
{
    public class User       
    {
        public int Id { get; set; }             // Identity column
        public string Name { get; set; } = default!;
        public string Username { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string PasswordHash { get; set; } = default!;
    }
}
