namespace CrmApi.DTOs
{
    public class SignUpDto
    {
        public string Name { get; set; } = null!;
        public string Username { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string Password { get; set; } = null!;
        public string? UserId { get; set; }
        public string? Token { get; set; }
    }
}
