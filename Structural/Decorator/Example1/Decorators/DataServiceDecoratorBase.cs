using Microsoft.Extensions.Caching.Memory;
using Structural.Decorator.Example1.IComponent;

namespace Structural.Decorator.Example1.Decorators
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
