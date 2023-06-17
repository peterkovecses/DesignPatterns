using Creational.Builder.Enums;
using Creational.Builder.Product;

namespace Creational.Builder.Builders
{
    // abstract builder
    public abstract class CarBuilderBase
    {
        protected Car Car { get; set; } = default!;

        public void BuilBody(BodyType bodyType)
        {
            Car.Body = bodyType;
        }

        public void BuildPainting(Color color)
        {
            Car.Painting= color;
        }

        public Car GetCar() 
        { 
            return Car;
        }
    }
}

