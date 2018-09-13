namespace Craftathon.Models.RequestDtos
{
    public class SendEmailRequestDto
    {
        public string EmailFrom { get; set; }

        public string EmailTo { get; set; }

        public string Subject { get; set; }

        public string Message { get; set; }
    }
}
