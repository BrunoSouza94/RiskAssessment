using RiskAssessment.Domain.Entities.Clients;

namespace RiskAssessment.Presentation.Validations;

public class InputValidations
{
    public ClientSectorEnum ValidateClientSector(string sector)
    {
        if (!Enum.TryParse(sector, out ClientSectorEnum clientSector))
            throw new ArgumentException("The client sector is not valid. Try Again.");

        return clientSector;
    }

    public decimal ValidateTradeValue(string stringValue)
    {
        if (!Decimal.TryParse(stringValue, out var value))
            throw new ArgumentException("The value of the operation is not valid. Try Again.");

        return value;
    }
}