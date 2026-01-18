using System.Net;
using System.Net.Mail;
using Microsoft.AspNetCore.Identity.UI.Services;

public class SmtpEmailSender : IEmailSender
{
    private readonly IConfiguration _config;

    public SmtpEmailSender(IConfiguration config)
    {
        _config = config ?? throw new ArgumentNullException(nameof(config));
    }

    public async Task SendEmailAsync(string toEmail, string subject, string body)
    {
        if (string.IsNullOrWhiteSpace(toEmail))
            throw new ArgumentException("Recipient email cannot be null or empty.", nameof(toEmail));

        var host = _config["Smtp:Host"]
            ?? throw new InvalidOperationException("SMTP Host is not configured.");
        var portString = _config["Smtp:Port"]
            ?? throw new InvalidOperationException("SMTP Port is not configured.");
        var username = _config["Smtp:Username"]
            ?? throw new InvalidOperationException("SMTP Username is not configured.");
        var password = _config["Smtp:Password"]
            ?? throw new InvalidOperationException("SMTP Password is not configured.");
        var from = _config["Smtp:From"] ?? username; // fallback to username if From not set

        if (!int.TryParse(portString, out var port))
            throw new InvalidOperationException("SMTP Port must be a valid number.");

        using var smtpClient = new SmtpClient(host)
        {
            Port = port,
            Credentials = new NetworkCredential(username, password),
            EnableSsl = true
        };

        using var mailMessage = new MailMessage
        {
            From = new MailAddress(from),
            Subject = subject ?? string.Empty,
            Body = body ?? string.Empty,
            IsBodyHtml = true
        };

        mailMessage.To.Add(toEmail);

        await smtpClient.SendMailAsync(mailMessage);
    }
}
