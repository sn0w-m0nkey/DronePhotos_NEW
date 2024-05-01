using System.Web;
using Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Web.Configuration;

namespace Web.Services;

public class EmailSender(IMailService mailService, IOptions<GmailConfig> options) : IEmailSender<ApplicationUser>
{
    public IMailService MailService { get; } = mailService;

    public async Task SendConfirmationLinkAsync(ApplicationUser user, string email, string confirmationLink)
    {
        await MailService.SendEmail(email, "Email Confirmation", HttpUtility.HtmlDecode(confirmationLink));
    }

    public async Task SendPasswordResetLinkAsync(ApplicationUser user, string email, string resetLink)
    {
        await MailService.SendEmail(email, "Password Reset Link", HttpUtility.HtmlDecode(resetLink));
    }

    public async Task SendPasswordResetCodeAsync(ApplicationUser user, string email, string resetCode)
    {
        await MailService.SendEmail(email, "Password Reset Code", HttpUtility.HtmlDecode(resetCode));
    }
}
