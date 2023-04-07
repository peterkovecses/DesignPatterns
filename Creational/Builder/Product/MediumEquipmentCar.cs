using Creational.Builder.Enums;

namespace Creational.Builder.Product
{
    public class MediumEquipmentCar : CarBase
    {
        public override EntertainmentSystemType EntertainmentSystem => EntertainmentSystemType.Radio;
        public override UpholsteryType Upholstery => UpholsteryType.TextileLeather;
    }
}
