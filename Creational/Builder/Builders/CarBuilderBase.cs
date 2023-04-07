using Creational.Builder.Enums;
using Creational.Builder.Product;

namespace Creational.Builder.Builders
{
    public abstract class CarBuilderBase
    {
        protected CarBase Car { get; set; } = default!;

        public void BuilBody(BodyType bodyType)
        {
            Car.Body = bodyType;
        }

        public void BuildPainting(Color color)
        {
            Car.Painting= color;
        }

        public CarBase GetCar() 
        { 
            return Car;
        }
    }
}
