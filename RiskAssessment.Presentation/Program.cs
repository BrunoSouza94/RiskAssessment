using Microsoft.Extensions.DependencyInjection;
using RiskAssessment.Application;
using RiskAssessment.Domain.Entities.Trades;
using RiskAssessment.Presentation;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        ServiceCollection services = new ServiceCollection();
        ConfigureServices(services);

        ServiceProvider provider = services.BuildServiceProvider();

        List<Trade>? portfolio = null;

        if (args.Length > 0)
        {
            try
            {
                portfolio = JsonSerializer.Deserialize<List<Trade>>(args[0]);
            }
            catch
            {
                Console.WriteLine("It was not possible to read the portfolio, please, try typing it.");
            }
        }

        provider.GetService<App>().Run(portfolio);
    }

    private static void ConfigureServices(ServiceCollection services)
    {
        services.AddApplication();
        services.AddDependencyInjectionConfiguration();
    }
}