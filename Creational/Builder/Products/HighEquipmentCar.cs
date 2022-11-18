using Creational.Builder.Enums;

namespace Creational.Builder.Products
{
    public class HighEquipmentCar : CarBase
    {
        public HighEquipmentCar()
        {
            EntertainmentSystem = EntertainmentSystemType.HiFi;
            Upholstery = UpholsteryType.Leather;
        }
    }
}
