using EmailSMTP.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EmailSMTP.Controllers
{
    public class EmailController : Controller
    {
        private readonly IEmailSenderInterface emailSender;

        public EmailController(IEmailSenderInterface emailSender)
        {
            this.emailSender = emailSender;
        }

        [HttpPost]
        public async Task<IActionResult> Index(EmailViewModel emailViewModel)
        {
            await emailSender.emailViewModel(emailViewModel.Email, emailViewModel.Subject, emailViewModel.Message);
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
