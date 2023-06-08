using Behavioral.Strategy.Example1.Strategies;

namespace Behavioral.Strategy.Example1.Resolver
{
    public interface IDeveloperSetupStrategyResolver
    {
        IDeveloperSetupStrategy GetStrategy(IDeveloper developer);
    }
}