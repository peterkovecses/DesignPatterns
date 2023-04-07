using Creational.Builder.Enums;

namespace Creational.Builder.Product
{
    public class HighEquipmentCar : CarBase
    {
        public override EntertainmentSystemType EntertainmentSystem => EntertainmentSystemType.HiFi;
        public override UpholsteryType Upholstery => UpholsteryType.Leather;
    }
}
