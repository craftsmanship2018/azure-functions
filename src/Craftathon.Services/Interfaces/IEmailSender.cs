using Craftathon.Models.RequestDtos;

namespace Craftathon.Services.Interfaces
{
    public interface IEmailSender
    {
        void Send(SendEmailRequestDto dto);
    }
}
