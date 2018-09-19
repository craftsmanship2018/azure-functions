using Craftathon.Models.RequestDtos;
using Craftathon.Services.Interfaces;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace Craftathon.Services.EmailSenders
{
    public class SendgridEmailSender : IEmailSender
    {
        private const string API_KEY = "";

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
