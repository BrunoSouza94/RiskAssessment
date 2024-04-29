using RiskAssessment.Domain.Entities.Risks;
using RiskAssessment.Domain.Entities.Trades;

namespace RiskAssessment.Application.Features.Trades.CalculateTradeRisk;

public sealed class ValidationRulesForPublicClient
{
    private const decimal MediumRiskThreshold = 1000000;

    public RiskCategoriesEnum DoCalculateRisk(Trade trade)
    {
        RiskCategoriesEnum category = trade.Value switch
        {
            > MediumRiskThreshold => RiskCategoriesEnum.MediumRisk,
            _ => RiskCategoriesEnum.LowRisk,
        };

        return category;
    }
}