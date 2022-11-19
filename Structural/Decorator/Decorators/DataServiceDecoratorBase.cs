using Microsoft.Extensions.Caching.Memory;
using Structural.Decorator.IComponent;

namespace Structural.Decorator.Decorators
{
    public class DataServiceDecoratorBase : IDataService
    {
        protected readonly IDataService _dataService;
        protected readonly IMemoryCache _memoryCache;

        public DataServiceDecoratorBase(IDataService dataService, IMemoryCache memoryCache)
        {
            _dataService = dataService;
            _memoryCache = memoryCache;
        }

        public abstract List<int> GetData();
    }
}
