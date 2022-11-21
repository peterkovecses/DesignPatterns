using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using Structural.Decorator.Example1.IComponent;
using System.Diagnostics;

namespace Structural.Decorator.Example1.Decorators
{
    public class DataServiceLoggingDecorator : DataServiceDecoratorBase
    {
        private readonly ILogger _logger;

        public DataServiceLoggingDecorator(IDataService dataService, ILogger logger) : base(dataService)
        {
            _logger = logger;
        }

        public override List<int> GetData()
        {
            _logger.LogInformation("Starting to get data");
            var stopwatch = Stopwatch.StartNew();

            var data = _dataService.GetData();

            stopwatch.Stop();
            var elapsedTime = stopwatch.ElapsedMilliseconds;

            _logger.LogInformation($"Finished getting data in {elapsedTime} milliseconds");

            return data;
        }
    }
}
