using Creational.Builder.Enums;

namespace Creational.Builder.Products
{
    public class BasicEquipmentCar : CarBase
    {
        public BasicEquipmentCar()
        {
            EntertainmentSystem = EntertainmentSystemType.None;
            Upholstery = UpholsteryType.Fabric;
        }
    }
}
