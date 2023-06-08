namespace Creational.FluentBuilder.StrictOrder;

public class StrictCarBuilder : IEntertainmentSystemStage, IUpholsteryStage, IBodyStage, IPaintingStage
{
    private readonly Car _car;

    // megtiltjuk a kívülről történő példányosítást
    private StrictCarBuilder() => _car = new();

    public static IBodyStage StartBuilding() => new StrictCarBuilder();

    public IPaintingStage SetBody(BodyType bodyType)
    {
        _car.Body = bodyType;
        return this;
    }

    public IUpholsteryStage SetPainting(Color color)
    {
        _car.Painting = color;
        return this;
    }

    public IEntertainmentSystemStage SetUpholstery(UpholsteryType upholsteryType)
    {
        _car.Upholstery = upholsteryType;
        return this;
    }

    public StrictCarBuilder SetEntertainmentSystem(EntertainmentSystemType entertainmentSystemType)
    {
        _car.EntertainmentSystem = entertainmentSystemType;
        return this;
    }

    public Car Build()
    {
        return _car;
    }
}

public interface IBodyStage
{
    IPaintingStage SetBody(BodyType bodyType);
}

public interface IPaintingStage
{
    IUpholsteryStage SetPainting(Color color);
}

public interface IUpholsteryStage
{
    IEntertainmentSystemStage SetUpholstery(UpholsteryType upholsteryType);
}

public interface IEntertainmentSystemStage
{
    StrictCarBuilder SetEntertainmentSystem(EntertainmentSystemType entertainmentSystemType);
}

public class ClientCode
{
    public static void Test()
    {
        // csak ebben a sorrendben működik, és az összeset meg kell hívni a Build-ig
        var car = StrictCarBuilder
            .StartBuilding()
            .SetBody(BodyType.Coupe)
            .SetPainting(Color.Blue)
            .SetUpholstery(UpholsteryType.TextileLeather)
            .SetEntertainmentSystem(EntertainmentSystemType.HiFi)
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
