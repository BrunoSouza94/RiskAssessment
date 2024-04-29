using RiskAssessment.Domain.Entities.Risks;
using RiskAssessment.Domain.Entities.Trades;

namespace RiskAssessment.Application.Abstractions;

public interface ITradeRiskCalculator
{
    RiskCategoriesEnum CalculateTradeRiskCategory(Trade trade);
}