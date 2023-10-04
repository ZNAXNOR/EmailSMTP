using EmailSMTP.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EmailSMTP.Controllers
{
    public class EmailController : Controller
    {
        private readonly IEmailSenderInterface _emailSender;

        public EmailController(IEmailSenderInterface emailSender)
        {
            _emailSender = emailSender;
        }

        [HttpPost]
        public async Task<IActionResult> Index(EmailViewModel emailViewModel)
        {
            for (int count = 0; count < 3; count++)
            {
                await _emailSender.SendEmailAsync(emailViewModel.Email, emailViewModel.Subject, emailViewModel.Message);

                Thread.Sleep(TimeSpan.FromSeconds(5));
            }                
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
