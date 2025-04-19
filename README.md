# ABM_06_ReportApp

## **Descrição**
O **ReportApp** é um projeto Razor Pages desenvolvido em .NET 9. Ele inclui funcionalidades para geração de relatórios e previsão do tempo, com suporte a envio de e-mails e APIs para integração.

---

## **Funcionalidades**
- **Geração de Relatórios**: Criação de relatórios com data e hora.
- **Envio de E-mails**: Envio automático de relatórios por e-mail.
- **Previsão do Tempo**: API para consultar previsões meteorológicas mockadas.

---

## **Estrutura do Projeto**
- **Interfaces**: Contém contratos para serviços (`IEmailService`, `IReportService`, etc.).
- **Services**: Implementações de serviços, como `ReportService` e `MockWeatherForecastService`.
- **Models**: Modelos de dados, como `WeatherForecast`.
- **Api**: Controladores de API, como `WeatherForecastController`.
- **Pages**: Arquivos Razor Pages para a interface do usuário.

---

## **Configuração**
1. Certifique-se de ter o **.NET 9 SDK** instalado.
2. Clone o repositório:
   
```shell
   git clone https://github.com/seu-repositorio/ReportApp.git
   cd ReportApp
   
```
3. Restaure as dependências:
   
```shell
   dotnet restore
   
```
4. Execute o projeto:
   
```shell
   dotnet run
   
```

---

## **Uso**
### **Geração de Relatórios**
O serviço `ReportService` gera relatórios e os envia por e-mail:

```csharp
var reportService = new ReportService(new EmailService());
string report = reportService.GenerateReport();
Console.WriteLine(report);

```

### **API de Previsão do Tempo**
Acesse a API de previsão do tempo em:

```
GET http://localhost:5074/weatherforecast/

```

---

## **Dependências**
- .NET 9
- Razor Pages

---

## **Contribuição**
1. Faça um fork do repositório.
2. Crie um branch para sua feature:
   
```shell
   git checkout -b minha-feature
   
```
3. Envie um pull request.
