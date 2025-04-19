using Microsoft.AspNetCore.Mvc;
using ReportApp.Interfaces;

namespace ReportApp.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ReportsController(IReportService reportService) : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        var report = reportService.GenerateReport();
        return Ok(new { Message = report });
    }
}
