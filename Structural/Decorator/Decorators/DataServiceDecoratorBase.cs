using Microsoft.Extensions.Caching.Memory;
using Structural.Decorator.IComponent;

namespace Structural.Decorator.Decorators
{
    public abstract class DataServiceDecoratorBase : IDataService
    {
        protected readonly IDataService _dataService;

        public DataServiceDecoratorBase(IDataService dataService)
        {
            _dataService = dataService;
        }

        public abstract List<int> GetData();
    }
}
