using Creational.Builder.Product;

namespace Creational.Builder.Builders
{
    public class BaseEquipmentCarBuilder : CarBuilderBase
    {
        public BaseEquipmentCarBuilder()
        {
            Car = new BaseEquipmentCar();
        }
    }
}
