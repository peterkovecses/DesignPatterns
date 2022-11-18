using Creational.Builder.Enums;
using Creational.Builder.Products;

namespace Creational.Builder.Builders
{
    public class MediumEquipmentCarBuilder : CarBuilderBase
    {
        public MediumEquipmentCarBuilder()
        {
            Car = new Car(EntertainmentSystemType.Radio, UpholsteryType.TextileLeather);
        }
    }
}
