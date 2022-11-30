using Behavioral.Strategy.Strategies;

namespace Behavioral.Strategy.Resolver
{
    public class DeveloperSetupStrategyResolver
    {
        public IDeveloperSetupStrategy GetStrategy(IDeveloper developer)
        {
            return developer.GetType().Name switch
            {
                nameof(MediorDeveloper) => new MediorDeveloperSetupStrategy(),
                nameof(SeniorDeveloper) => new SeniorDeveloperSetupStrategy(),
                _ => new JuniorDeveloperSetupStrategy()
            };
        }
    }
}
