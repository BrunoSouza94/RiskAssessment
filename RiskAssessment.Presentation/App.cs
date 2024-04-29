using RiskAssessment.Application.Abstractions;
using RiskAssessment.Domain.Entities.Trades;
using RiskAssessment.Presentation.Reader;
using System.Text.Json;

namespace RiskAssessment.Presentation;

public class App
{
    private IInputReader _inputReader;
    private IPortfolioDataProcessor _portfolioDataProcessor;

    public App(IInputReader inputReader, IPortfolioDataProcessor portfolioDataProcessor)
    {
        _inputReader = inputReader;
        _portfolioDataProcessor = portfolioDataProcessor;
    }

    public void Run(List<Trade>? portfolio = null)
    {
        if (portfolio is not null)
        {
            var result = ProcessPortfolio(portfolio);

            WriteResult(result);
        }
        else
        {
            var inputPortfolio = ReadPortfolio();
            var result = ProcessPortfolio(inputPortfolio);

            WriteResult(result);
        }
    }

    private List<Trade> ReadPortfolio()
    {
        bool keepGoing = true;
        List<Trade> portfolio = new();

        while (keepGoing)
        {
            try
            {
                Trade trade = _inputReader.ReadInput();

                portfolio.Add(trade);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                continue;
            }

            Console.WriteLine("Add another one? \n 1 - Yes \n 2 - No");
            Int16.TryParse(Console.ReadLine(), out var value);

            if (value.Equals(2))
                keepGoing = false;
        }

        return portfolio;
    }

    private List<string> ProcessPortfolio(List<Trade> portfolio)
    {
        return _portfolioDataProcessor.ProcessPortfolio(portfolio);
    }

    private void WriteResult(List<string> result)
    {
        Console.WriteLine(JsonSerializer.Serialize(result));
    }
}