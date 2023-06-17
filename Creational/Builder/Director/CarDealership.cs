using Creational.Builder.Builders;
using Creational.Builder.Enums;
using Creational.Builder.Product;

namespace Creational.Director.Builder
{
    // director
    public class CarDealership
    {
        public static Car OrderCar(CarBuilderBase carBuilder, BodyType bodyType, Color color)
        {
            carBuilder.BuilBody(bodyType);
            carBuilder.BuildPainting(color);

            return carBuilder.GetCar();
        }
    }
}
