using Microsoft.Extensions.Options;
using MiniStore.Application.Interfaces;
using MiniStore.Application.SendGrid;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace MiniStore.Application.Services
{
    public class EmailService : IEmailService
    {
        private readonly ISendGridClient _sendGridClient;
        private readonly IOptions<SendGridOptions> _options;

        public EmailService(ISendGridClient sendGridClient, IOptions<SendGridOptions> options)
        {
           _sendGridClient = sendGridClient;
           _options = options;
        }

        public async Task<bool> SendEmailAsync(string toEmail, string subject, string content)
        {
            var from = new EmailAddress(_options.Value.Email, _options.Value.Nome);
            var to = new EmailAddress(toEmail);
            var message = MailHelper.CreateSingleEmail(from, to, subject, content, content);
            var response = await _sendGridClient.SendEmailAsync(message);
            return response.StatusCode == System.Net.HttpStatusCode.Accepted;
        }
    }
}
