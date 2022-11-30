using Behavioral.Strategy.Strategies;

namespace Behavioral.Strategy.Resolver
{
    public class DeveloperSetupStrategyResolver
    {
        public IDeveloperSetupStrategy GetStrategy(IDeveloper developer)
        {
            return developer switch
            {
                MediorDeveloper => new MediorDeveloperSetupStrategy(),
                SeniorDeveloper => new SeniorDeveloperSetupStrategy(),
                _ => new JuniorDeveloperSetupStrategy()
            };
        }
    }
}
