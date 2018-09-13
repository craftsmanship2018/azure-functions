using Craftathon.Models.RequestDtos;
using Craftathon.Services.Interfaces;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace Craftathon.Services.EmailSenders
{
    public class SendgridEmailSender : IEmailSender
    {
        private const string API_KEY = "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";

        public void Send(SendEmailRequestDto dto)
        {
            var client = new SendGridClient(API_KEY);

            var msg = new SendGridMessage
            {
                From = new EmailAddress(dto.EmailFrom),
                Subject = dto.Subject,
                PlainTextContent = dto.Message
            };

            msg.AddTo(new EmailAddress(dto.EmailTo));

            var response = client.SendEmailAsync(msg).Result;
        }
    }
}
