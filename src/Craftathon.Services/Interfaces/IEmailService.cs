using Craftathon.Models.RequestDtos;

namespace Craftathon.Services.Interfaces
{
    public interface IEmailService
    {
        void Send(SendEmailRequestDto dto);
    }
}
