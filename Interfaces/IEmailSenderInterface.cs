public interface IEmailSenderInterface
{
    Task emailViewModel(string Email, string Subject, string Message);
}