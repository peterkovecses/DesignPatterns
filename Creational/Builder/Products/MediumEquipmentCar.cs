using Creational.Builder.Enums;

namespace Creational.Builder.Products
{
    public class MediumEquipmentCar : CarBase
    {
        public MediumEquipmentCar()
        {
            EntertainmentSystem = EntertainmentSystemType.Radio;
            Upholstery = UpholsteryType.TextileLeather;
        }
    }
}
