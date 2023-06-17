using Creational.Builder.Enums;

namespace Creational.Builder.Product
{
    public class Car
    {
        public EntertainmentSystemType EntertainmentSystem { get; set; }
        public UpholsteryType Upholstery { get; set; }
        public BodyType Body { get; set; }
        public Color Painting { get; set; }
    }
}
