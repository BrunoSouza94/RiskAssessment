using RiskAssessment.Domain.Entities.Clients;
using RiskAssessment.Domain.Entities.Trades;

namespace RiskAssessment.Presentation.Processors;

public interface IInputProcessor
{
    Trade ProcessInput(decimal value, ClientSectorEnum sector);
}