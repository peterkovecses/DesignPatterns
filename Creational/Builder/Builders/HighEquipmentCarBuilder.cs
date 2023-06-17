using Creational.Builder.Product;

namespace Creational.Builder.Builders
{
    // concrete builder
    public class HighEquipmentCarBuilder : CarBuilderBase
    {
        public HighEquipmentCarBuilder()
        {
            Car = new Car
            {
                EntertainmentSystem = Enums.EntertainmentSystemType.HiFi,
                Upholstery = Enums.UpholsteryType.Leather
            };
        }
    }
}
