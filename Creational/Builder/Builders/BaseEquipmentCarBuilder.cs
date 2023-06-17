using Creational.Builder.Product;

namespace Creational.Builder.Builders
{
    public class BaseEquipmentCarBuilder : CarBuilderBase
    {
        public BaseEquipmentCarBuilder()
        {
            Car = new Car
            {
                EntertainmentSystem = Enums.EntertainmentSystemType.None,
                Upholstery = Enums.UpholsteryType.Fabric
            };
        }
    }
}
