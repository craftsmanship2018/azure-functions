using Craftathon.Models.RequestDtos;
using Craftathon.Services.Interfaces;

namespace Craftathon.Services
{
    public class EmailService : IEmailService
    {
        private readonly IEmailSender _emailSender;

        public EmailService(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        public void Send(SendEmailRequestDto dto)
        {
            _emailSender.Send(dto);
        }
    }
}
