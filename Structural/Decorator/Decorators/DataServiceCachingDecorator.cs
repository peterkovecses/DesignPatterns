﻿using Microsoft.Extensions.Caching.Memory;
using Structural.Decorator.IComponent;

namespace Structural.Decorator.Decorators
{

    public class DataServiceCachingDecorator : DataServiceDecoratorBase
    {
        public DataServiceCachingDecorator(IDataService dataService, IMemoryCache memoryCache) : base(dataService, memoryCache)
        {
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
