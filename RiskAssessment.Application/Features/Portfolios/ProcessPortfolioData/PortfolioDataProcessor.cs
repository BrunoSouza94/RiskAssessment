using RiskAssessment.Application.Abstractions;
using RiskAssessment.Domain.Entities.Risks;
using RiskAssessment.Domain.Entities.Trades;

namespace RiskAssessment.Application.Features.Portfolios.ProcessPortfolioData;

public sealed class PortfolioDataProcessor : IPortfolioDataProcessor
{
    private ITradeRiskCalculator _tradeRiskCalculator;

    public PortfolioDataProcessor(ITradeRiskCalculator tradeRiskCalculator)
    {
        _tradeRiskCalculator = tradeRiskCalculator;
    }

    public List<string> ProcessPortfolio(List<Trade> portfolio)
    {
        List<string> result = new();

        portfolio.ForEach(trade =>
        {
            try
            {
                RiskCategoriesEnum risk = _tradeRiskCalculator.CalculateTradeRiskCategory(trade);

                result.Add(risk.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        });

        return result;
    }
}