using RiskAssessment.Domain.Entities.Clients;
using RiskAssessment.Domain.Entities.Trades;

namespace RiskAssessment.Presentation.Processors;

public sealed class InputProcessor : IInputProcessor
{
    public Trade ProcessInput(decimal value, ClientSectorEnum sector)
    {
        return new Trade
        {
            Value = value,
            ClientSector = sector.ToString()
        };
    }
}