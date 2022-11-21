using Microsoft.Extensions.Caching.Memory;
using Structural.Decorator.Example1.IComponent;

namespace Structural.Decorator.Example1.Decorators
{

    public class DataServiceCachingDecorator : DataServiceDecoratorBase
    {
        private readonly IMemoryCache _memoryCache;

        public DataServiceCachingDecorator(IDataService dataService, IMemoryCache memoryCache) : base(dataService)
        {
            _memoryCache = memoryCache;
        }

        public override List<int> GetData()
        {
            const string cacheKey = "data-key";

            if (_memoryCache.TryGetValue<List<int>>(cacheKey, out var data))
            {
                return data;
            }

            data = _dataService.GetData();

            _memoryCache.Set(cacheKey, data, TimeSpan.FromMinutes(120));

            return data;
        }
    }
}
