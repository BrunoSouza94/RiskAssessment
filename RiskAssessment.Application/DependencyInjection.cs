using Microsoft.Extensions.DependencyInjection;
using RiskAssessment.Application.Abstractions;
using RiskAssessment.Application.Features.Portfolios.ProcessPortfolioData;
using RiskAssessment.Application.Features.Trades.CalculateTradeRisk;

namespace RiskAssessment.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<ITradeRiskCalculator, TradeRiskCalculator>();
        services.AddScoped<IPortfolioDataProcessor, PortfolioDataProcessor>();

        return services;
    }
}