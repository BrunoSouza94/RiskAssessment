using RiskAssessment.Domain.Entities.Trades;
using RiskAssessment.Presentation.Processors;
using RiskAssessment.Presentation.Validations;

namespace RiskAssessment.Presentation.Reader;

public sealed class InputReader : IInputReader
{
    private IInputProcessor _inputProcessor;

    public InputReader(IInputProcessor inputProcessor)
    {
        _inputProcessor = inputProcessor;
    }

    public Trade ReadInput()
    {
        Console.WriteLine("Type the client sector (Private or Public):");
        var sector = Console.ReadLine();

        Console.WriteLine("Type the operation value:");
        var stringValue = Console.ReadLine();

        var inputValidations = new InputValidations();

        var clientSector = inputValidations.ValidateClientSector(sector);
        var value = inputValidations.ValidateTradeValue(stringValue);

        return _inputProcessor.ProcessInput(value, clientSector);
    }
}