using RiskAssessment.Domain.Entities.Trades;

namespace RiskAssessment.Application.Abstractions;

public interface IPortfolioDataProcessor
{
    List<string> ProcessPortfolio(List<Trade> portfolio);
}