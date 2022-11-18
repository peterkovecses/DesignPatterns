using Creational.FluentBuilder.Enums;
using Creational.FluentBuilder.Builder;

namespace Creational.FluentBuilder
{
    public class ClientCode
    {
        public static void Test() 
        {
            var builder = new CarBuilder();

            var car = builder
                .SetBody(BodyType.Coupe)
                .SetPainting(Color.Blue)
                .SetEntertainmentSystem(EntertainmentSystemType.HiFi)
                .SetUpholstery(UpholsteryType.TextileLeather)
                .Build();
        }
    }
}
