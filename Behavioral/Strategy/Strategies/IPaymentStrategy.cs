namespace Behavioral.Strategy.Strategies
{
    public interface IDeveloperSetupStrategy
    {
        void SetDeveloper(IDeveloper developer, double baseSalary);
    }

    public class JuniorDeveloperSetupStrategy : IDeveloperSetupStrategy
    {
        private const double SalaryMultiplier = 1;
        private const string Prefix = "Junior";

        public void SetDeveloper(IDeveloper developer, double baseSalary)
        {
            developer
                .SetTitle(Prefix)
                .SetSalary(SalaryMultiplier, baseSalary);
        }
    }

    public class MediorDeveloperSetupStrategy : IDeveloperSetupStrategy
    {
        private const double SalaryMultiplier = 1.5;
        private const string Prefix = "Medior";

        public void SetDeveloper(IDeveloper developer, double baseSalary)
        {
            developer
                .SetTitle(Prefix)
                .SetSalary(SalaryMultiplier, baseSalary);
        }
    }

    public class SeniorDeveloperSetupStrategy : IDeveloperSetupStrategy
    {
        private const double SalaryMultiplier = 2;
        private const string Prefix = "Senior";

        public void SetDeveloper(IDeveloper developer, double baseSalary)
        {
            developer
                .SetTitle(Prefix)
                .SetSalary(SalaryMultiplier, baseSalary);
        }
    }
}
