using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using Structural.Decorator.IComponent;
using System.Diagnostics;

namespace Structural.Decorator.Decorators
{
    public class DataServiceLoggingDecorator : DataServiceDecoratorBase
    {
        public DataServiceLoggingDecorator(IDataService dataService, IMemoryCache memoryCache) : base(dataService, memoryCache)
        {
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
