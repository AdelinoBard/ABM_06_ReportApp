using ReportApp.Interfaces;

namespace ReportApp.Services;

public class EmailService : IEmailService
{
    public void Send(string to, string subject, string body)
    {
        Console.WriteLine($"Email enviado para {to}: {subject} - {body}");
    }
}
