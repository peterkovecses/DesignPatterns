using Creational.Builder.Enums;

namespace Creational.Builder.Product
{
    public class MediumEquipmentCar : Car
    {
        public override EntertainmentSystemType EntertainmentSystem => EntertainmentSystemType.Radio;
        public override UpholsteryType Upholstery => UpholsteryType.TextileLeather;
    }
}
