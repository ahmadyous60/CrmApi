﻿namespace CrmApi.DTOs
{
    public class ConfirmEmailDto
    {
        public string UserId { get; set; } = null!;
        public string Token { get; set; } = null!;
    }
}
