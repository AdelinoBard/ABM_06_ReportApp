using ReportApp.Interfaces;
using ReportApp.Services;

var builder = WebApplication.CreateBuilder(args);

// Serviços
builder.Services.AddScoped<IEmailService, EmailService>();
builder.Services.AddScoped<IReportService, ReportService>();

// Registrar o serviço mockado
builder.Services.AddSingleton<IWeatherForecastService, MockWeatherForecastService>();

// Adiciona suporte a controladores e páginas Razor
builder.Services.AddControllers();
builder.Services.AddRazorPages();

var app = builder.Build();

// Roteamento
app.UseStaticFiles();
app.UseRouting();

app.MapControllers();
app.MapRazorPages();

app.Run();