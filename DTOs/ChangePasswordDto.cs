namespace CrmApi.DTOs
{
    public class ChangePasswordDto
    {
        public string UserId { get; set; } = null!;
        public string Token { get; set; } = null!;
        public string OldPassword { get; set; } = null!;
        public string NewPassword { get; set; } = null!;
    }
}
