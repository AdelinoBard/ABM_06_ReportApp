using ReportApp.Interfaces;

namespace ReportApp.Services;

public class ReportService(IEmailService emailService) : IReportService
{
    public string GenerateReport()
    {
        string report = $"Relatório gerado em {DateTime.Now}";
        emailService.Send("usuario@teste.com", "Seu relatório", report);
        return report;
    }
}
