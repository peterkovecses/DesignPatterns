namespace Behavioral.Strategy.Example1.Strategies
{
    public interface IDeveloperSetupStrategy
    {
        void SetDeveloper(IDeveloper developer, double baseSalary);
    }

    public class JuniorDeveloperSetupStrategy : IDeveloperSetupStrategy
    {
        public const double SalaryMultiplier = 1;
        public const string Prefix = "Junior";

        public void SetDeveloper(IDeveloper developer, double baseSalary)
        {
            developer
                .SetTitle(Prefix)
                .SetSalary(SalaryMultiplier, baseSalary);
        }
    }

    public class MediorDeveloperSetupStrategy : IDeveloperSetupStrategy
    {
        public const double SalaryMultiplier = 1.5;
        public const string Prefix = "Medior";

        public void SetDeveloper(IDeveloper developer, double baseSalary)
        {
            developer
                .SetTitle(Prefix)
                .SetSalary(SalaryMultiplier, baseSalary);
        }
    }

    public class SeniorDeveloperSetupStrategy : IDeveloperSetupStrategy
    {
        public const double SalaryMultiplier = 2;
        public const string Prefix = "Senior";

        public void SetDeveloper(IDeveloper developer, double baseSalary)
        {
            developer
                .SetTitle(Prefix)
                .SetSalary(SalaryMultiplier, baseSalary);
        }
    }
}
