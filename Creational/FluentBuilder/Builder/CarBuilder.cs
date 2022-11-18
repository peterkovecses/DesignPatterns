using Creational.FluentBuilder.Enums;
using Creational.FluentBuilder.Product;

namespace Creational.FluentBuilder.Builder
{
    public class CarBuilder
    {
        private readonly Car _car;

        public CarBuilder()
        {
            _car = new();
        }

        public CarBuilder SetEntertainmentSystem(EntertainmentSystemType entertainmentSystemType)
        {
            _car.EntertainmentSystem = entertainmentSystemType;
            return this;
        }

        public CarBuilder SetUpholstery(UpholsteryType upholsteryType)
        {
            _car.Upholstery = upholsteryType;
            return this;
        }

        public CarBuilder SetBody(BodyType bodyType)
        {
            _car.Body = bodyType;
            return this;
        }

        public CarBuilder SetPainting(Color color)
        {
            _car.Painting = color;
            return this;
        }

        public Car Build()
        {
            return _car;
        }
    }
}
