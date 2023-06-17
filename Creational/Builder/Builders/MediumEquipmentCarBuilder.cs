using Creational.Builder.Product;

namespace Creational.Builder.Builders
{
    public class MediumEquipmentCarBuilder : CarBuilderBase
    {
        public MediumEquipmentCarBuilder()
        {
            Car = new Car
            {
                EntertainmentSystem = Enums.EntertainmentSystemType.Radio,
                Upholstery = Enums.UpholsteryType.TextileLeather
            };
        }
    }
}
