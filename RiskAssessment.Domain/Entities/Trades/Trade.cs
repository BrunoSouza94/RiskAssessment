using RiskAssessment.Domain.Abstractions;

namespace RiskAssessment.Domain.Entities.Trades;

public class Trade : ITrade
{
    public decimal Value { get; init; }

    public string ClientSector { get; init; }
}