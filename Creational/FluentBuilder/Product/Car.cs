using Creational.FluentBuilder.Enums;

namespace Creational.FluentBuilder.Product
{
    public class Car
    {
        public EntertainmentSystemType EntertainmentSystem { get; set; }
        public UpholsteryType Upholstery { get; set; }
        public BodyType Body { get; set; }
        public Color Painting { get; set; }
    }
}
