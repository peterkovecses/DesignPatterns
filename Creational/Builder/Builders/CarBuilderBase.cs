using Creational.Builder.Enums;
using Creational.Builder.Products;

namespace Creational.Builder.Builders
{
    public abstract class CarBuilderBase
    {
        protected CarBase _car = default!;

        public CarBase Car { get => _car; }

        public void BuilBody(BodyType bodyType)
        {
            _car.Body= bodyType;
        }

        public void BuildPainting(Color color)
        {
            _car.Painting= color;
        }

        public CarBase GetCar() 
        { 
            return _car;
        }
    }
}
