using Craftathon.Models.RequestDtos;
using Craftathon.Models.ViewModels;
using Craftathon.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Craftathon.WebUI.Controllers
{
    public class DemoController : Controller
    {
        private readonly IEmailSender _sendgridEmailSender;
        private readonly IEmailSender _smtpEmailSender;

        private const string EMAIL_FROM = "temp@craftathon.co.uk";

        public DemoController(
            IEmailSender sendgridEmailSender,
            IEmailSender smtpEmailSender)
        {
            _sendgridEmailSender = sendgridEmailSender;
            _smtpEmailSender = smtpEmailSender;
        }

        [Route("/demo")]
        [HttpGet]
        public IActionResult Index()
        {
            return View("../Demo");
        }

        [Route("/demo/smtp")]
        [HttpPost]
        public IActionResult SendEmailUsingSmtp(EmailViewModel viewModel)
        {
            if(!ModelState.IsValid) return View("../Demo");

            var request = new SendEmailRequestDto
            {
                EmailFrom = EMAIL_FROM,
                EmailTo = viewModel.EmailAddress,
                Subject = viewModel.Subject,
                Message = viewModel.Message
            };

            _smtpEmailSender.Send(request);

            ModelState.Clear();
            return View("../Demo");
        }

        [Route("/demo/sendgrid")]
        [HttpPost]
        public IActionResult SendEmailUsingSendgrid(EmailViewModel viewModel)
        {
            if(!ModelState.IsValid) return View("../Demo");

            var request = new SendEmailRequestDto
            {
                EmailFrom = EMAIL_FROM,
                EmailTo = viewModel.EmailAddress,
                Subject = viewModel.Subject,
                Message = viewModel.Message
            };

            _sendgridEmailSender.Send(request);

            ModelState.Clear();
            return View("../Demo");
        }
    }
}