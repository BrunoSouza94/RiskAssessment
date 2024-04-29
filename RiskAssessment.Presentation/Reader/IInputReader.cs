using RiskAssessment.Domain.Entities.Trades;

namespace RiskAssessment.Presentation.Reader;

public interface IInputReader
{
    public Trade ReadInput();
}