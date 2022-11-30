﻿using Behavioral.Strategy.Resolver;

namespace Behavioral.Strategy
{
    public class HrService
    {
        private readonly DeveloperSetupStrategyResolver _developerSetupStrategyResolver;
        private const double DeveloperBaseSalary = 50000;
        public List<IDeveloper> Developers { get; set; }

        public HrService(DeveloperSetupStrategyResolver strategyResolver)
        {
            _developerSetupStrategyResolver = strategyResolver;
            Developers = new List<IDeveloper>();
        }

        public void HireDeveloper(IDeveloper developer)
        {            
            var strategy = _developerSetupStrategyResolver.GetStrategy(developer);
            strategy.SetDeveloper(developer, DeveloperBaseSalary);
            Developers.Add(developer);
        }
    }

    public interface IDeveloper
    {
        public string Specialization { get; set; }
        public string? Title { get; set; }
        public double TotalSalary { get; set; }
    }

    public class JuniorDeveloper : IDeveloper
    {
        public string Specialization { get; set; } = default!;
        public string? Title { get; set; }
        public double TotalSalary { get; set; }
    }

    public class MediorDeveloper : IDeveloper
    {
        public string Specialization { get; set; } = default!;
        public string? Title { get; set; }
        public double TotalSalary { get; set; }
    }

    public class SeniorDeveloper : IDeveloper
    {
        public string Specialization { get; set; } = default!;
        public string? Title { get; set; }
        public double TotalSalary { get; set; }
    }

    public static class DeveloperExtensions
    {
        public static IDeveloper SetSalary(this IDeveloper developer, double multiplier, double baseSalary)
        {
            developer.TotalSalary = baseSalary * multiplier;
            return developer;
        }

        public static IDeveloper SetTitle(this IDeveloper developer, string prefix)
        {
            developer.Title = $"{prefix} {developer.Specialization} Developer";
            return developer;
        }
    }
}
