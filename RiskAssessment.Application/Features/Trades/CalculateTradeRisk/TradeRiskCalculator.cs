using RiskAssessment.Application.Abstractions;
using RiskAssessment.Domain.Abstractions;
using RiskAssessment.Domain.Entities.Clients;
using RiskAssessment.Domain.Entities.Risks;
using RiskAssessment.Domain.Entities.Trades;

namespace RiskAssessment.Application.Features.Trades.CalculateTradeRisk;

public sealed class TradeRiskCalculator : ITradeRiskCalculator
{
    public RiskCategoriesEnum CalculateTradeRiskCategory(Trade trade)
    {
        Enum.TryParse(trade.ClientSector, out ClientSectorEnum clientSector);

        switch (clientSector)
        {
            case ClientSectorEnum.Public:
                return CalculateForPublicClient(trade);
            case ClientSectorEnum.Private:
                return CalculateForPrivateClient(trade);
            default:
                throw new ArgumentException("The received client sector was not found");
        }
    }

    private RiskCategoriesEnum CalculateForPublicClient(Trade trade)
    {
        var validationRules = new ValidationRulesForPublicClient();

        return validationRules.DoCalculateRisk(trade);
    }

    private RiskCategoriesEnum CalculateForPrivateClient(Trade trade)
    {
        var validationRules = new ValidationRulesForPrivateClient();

        return validationRules.DoCalculateRisk(trade);
    }
}