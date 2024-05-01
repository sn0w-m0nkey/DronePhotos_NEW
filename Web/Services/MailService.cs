using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Options;
using MimeKit;
using Web.Configuration;

namespace Web.Services;

public interface IMailService
{
    Task SendEmail(string toEmail, string subject, string body);
}

public class MailService(IOptions<GmailConfig> options) : IMailService
{
    private readonly GmailConfig _config = options.Value;
    
    public async Task SendEmail(string toEmail, string subject, string body)
    {
        await SendEmail(toEmail, "noreply@drone-pics.com", subject, body);
    }

    public async Task SendEmail(string toEmail, string fromEmail, string subject, string body)
    {
        try
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("DronePix", fromEmail));
            message.To.Add(new MailboxAddress("", toEmail));
            message.Subject = subject;
            message.Body = new TextPart("plain") { Text = body };
            
            using (var client = new SmtpClient())
            {
                client.Connect(_config.Server, _config.Port, SecureSocketOptions.StartTls);
                client.Authenticate(_config.Username, _config.Password);
                client.Send(message);
                client.Disconnect(true);
            }
        }
        catch (Exception e)
        {
            // TODO: Log exception
            Console.WriteLine(e);
            throw new Exception();
        }
    }
}
