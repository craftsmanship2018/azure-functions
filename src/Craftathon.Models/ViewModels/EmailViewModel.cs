using System.ComponentModel.DataAnnotations;

namespace Craftathon.Models.ViewModels
{
    public class EmailViewModel
    {
        [Required(ErrorMessage = "Email address is required")]
        [EmailAddress]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Subject is required")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Message is required")]
        [MaxLength(2048)]
        public string Message { get; set; }
    }
}
