using CrmApi.Models;
using Microsoft.AspNetCore.Identity;

public class RefreshToken
{
    public int Id { get; set; }
    public string UserId { get; set; } = string.Empty;
    public string Token { get; set; } = string.Empty;
    public DateTime Expires { get; set; }  // matches SQL column
    public bool IsRevoked { get; set; } = false;
    public ApplicationUser? User { get; set; } = null;  // nullable
}

