
namespace CrmApi.Services
{
    public interface IEMailSender
    {
        Task SendEmailAsync(string toEmail, string subject, string body);
    }
}
