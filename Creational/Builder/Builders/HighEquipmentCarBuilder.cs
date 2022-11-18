using Creational.Builder.Enums;
using Creational.Builder.Product;

namespace Creational.Builder.Builders
{
    public class HighEquipmentCarBuilder : CarBuilderBase
    {
        public HighEquipmentCarBuilder()
        {
            Car = new Car(EntertainmentSystemType.HiFi, UpholsteryType.Leather);
        }
    }
}
