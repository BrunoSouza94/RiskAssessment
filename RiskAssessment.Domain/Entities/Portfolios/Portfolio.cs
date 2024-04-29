using RiskAssessment.Domain.Entities.Trades;

namespace RiskAssessment.Domain.Entities.Portfolios;

public sealed class Portfolio
{
    public List<Trade> Trades { get; set; }
}