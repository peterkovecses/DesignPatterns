using Behavioral.Strategy.Example1.Strategies;

namespace Behavioral.Strategy.Example1.Resolver
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
