using Creational.Builder.Enums;

namespace Creational.Builder.Product
{
    public class Car
    {
        public EntertainmentSystemType EntertainmentSystem { get; }
        public UpholsteryType Upholstery { get; }
        public BodyType Body { get; set; }
        public Color Painting { get; set; }

        public Car(EntertainmentSystemType entertainmentSystem, UpholsteryType upholstery)
        {
            EntertainmentSystem = entertainmentSystem;
            Upholstery = upholstery;
        }
    }
}
