using Creational.Builder.Builders;
using Creational.Builder.Enums;
using Creational.Builder.Products;

namespace Creational.Director.Builder
{
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
