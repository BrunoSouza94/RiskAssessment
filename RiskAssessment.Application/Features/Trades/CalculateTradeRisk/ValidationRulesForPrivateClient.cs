using RiskAssessment.Domain.Entities.Risks;
using RiskAssessment.Domain.Entities.Trades;

namespace RiskAssessment.Application.Features.Trades.CalculateTradeRisk;

public sealed class ValidationRulesForPrivateClient
{
    private const decimal HighRiskThreshold = 1000000;

    public RiskCategoriesEnum DoCalculateRisk(Trade trade)
    {
        RiskCategoriesEnum category = trade.Value switch
        {
            > HighRiskThreshold => RiskCategoriesEnum.HighRisk,
            _ => RiskCategoriesEnum.LowRisk,
        };

        return category;
    }
}