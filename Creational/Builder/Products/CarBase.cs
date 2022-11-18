using Creational.Builder.Enums;

namespace Creational.Builder.Products
{
    public abstract class CarBase
    {
        public EntertainmentSystemType EntertainmentSystem { get; protected set; }
        public UpholsteryType Upholstery { get; protected set; }
        public BodyType Body { get; set; }
        public Color Painting { get; set; }
    }
}
