using Craftathon.Models.RequestDtos;
using Craftathon.Services.Interfaces;
using System.Net;
using System.Net.Mail;

namespace Craftathon.Services.EmailSenders
{
    public class SmtpEmailSender : IEmailSender
    {
        public void Send(SendEmailRequestDto dto)
        {
            // emails sent via this test SMTP server will not actually send, it will be captured
            // by the inbox in your mailtrap.io account https://mailtrap.io
            var smtpClient = new SmtpClient
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.mailtrap.io",
                EnableSsl = true,
                Credentials = new NetworkCredential("f68811065829f5", "4036f4f3d836a6")
            };

            using (smtpClient)
            {
                smtpClient.Send( new MailMessage
                {
                    From = new MailAddress(dto.EmailFrom),
                    To = { new MailAddress(dto.EmailTo) },
                    Subject = dto.Subject,
                    Body = dto.Message
                });
            }
        }
    }
}
