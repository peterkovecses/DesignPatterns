using Creational.Builder.Enums;

namespace Creational.Builder.Product
{
    public abstract class CarBase
    {
        public virtual EntertainmentSystemType EntertainmentSystem { get; }
        public virtual UpholsteryType Upholstery { get; }
        public BodyType Body { get; set; }
        public Color Painting { get; set; }
    }
}
