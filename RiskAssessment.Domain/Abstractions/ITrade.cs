namespace RiskAssessment.Domain.Abstractions;

public interface ITrade
{
    decimal Value { get; }
    string ClientSector { get; }
}