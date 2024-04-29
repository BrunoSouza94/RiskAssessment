using Microsoft.Extensions.DependencyInjection;
using RiskAssessment.Presentation.Processors;
using RiskAssessment.Presentation.Reader;

namespace RiskAssessment.Presentation;

public static class DependencyInjection
{
    public static IServiceCollection AddDependencyInjectionConfiguration(this IServiceCollection services)
    {
        services.AddTransient<App>();
        
        services.AddScoped<IInputReader, InputReader>();
        services.AddScoped<IInputProcessor, InputProcessor>();

        return services;
    }
}