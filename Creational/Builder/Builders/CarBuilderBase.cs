using Creational.Builder.Enums;
using Creational.Builder.Products;

namespace Creational.Builder.Builders
{
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
