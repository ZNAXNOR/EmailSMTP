using System.Net;
using System.Net.Mail;

public class EmailSenderService : IEmailSenderInterface
{
    public Task emailViewModel(string Email, string Subject, string Message)
    {
        var client = new SmtpClient("Host", 587)
        {
            EnableSsl = true,
            UseDefaultCredentials = false,
            Credentials = new NetworkCredential("Username", "Password")
        };

        return client.SendMailAsync(
            new MailMessage(from: "Username",
                            to: Email, Subject, Message
                            ));
    }
}

