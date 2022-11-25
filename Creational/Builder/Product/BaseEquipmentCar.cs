using Creational.Builder.Enums;

namespace Creational.Builder.Product
{
    public class BaseEquipmentCar : Car
    {
        public override EntertainmentSystemType EntertainmentSystem => EntertainmentSystemType.None;
        public override UpholsteryType Upholstery => UpholsteryType.Fabric;
    }
}
