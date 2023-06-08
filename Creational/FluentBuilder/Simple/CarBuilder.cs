namespace Creational.FluentBuilder.Simple;

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

public class Car
{
    public EntertainmentSystemType EntertainmentSystem { get; set; }
    public UpholsteryType Upholstery { get; set; }
    public BodyType Body { get; set; }
    public Color Painting { get; set; }
}

public enum BodyType
{
    ThreeDoors,
    FourDoors,
    FiveDoors,
    Coupe,
    StationWagon,
    SUV
}

public enum Color
{
    White,
    Blue,
    Green,
    Yellow,
    Red,
    Black,
    Silver
}

public enum EntertainmentSystemType
{
    None,
    Radio,
    HiFi
}

public enum UpholsteryType
{
    Fabric,
    TextileLeather,
    Leather
}
