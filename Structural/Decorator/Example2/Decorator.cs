namespace Structural.Decorator.Example2;

public interface ISuperHero
{
    int Attack { get; }
    int Defence { get; }
}

public class SuperHero : ISuperHero
{
    public int Attack => 50;
    public int Defence => 50;

    public override string ToString() => $"Attack: {Attack}, Defence: {Defence}";
}

public abstract class HeroDecorator : ISuperHero
{
    protected ISuperHero _superHero;

    protected HeroDecorator(ISuperHero superHero)
    {
        _superHero = superHero;
    }

    public virtual int Attack => _superHero.Attack;
    public virtual int Defence => _superHero.Defence;

    public override string ToString() => $"Attack: {Attack}, Defence: {Defence}";
}

public class AttackDecorator : HeroDecorator
{
    public AttackDecorator(ISuperHero superHero) : base(superHero)
    {
    }

    public override int Attack => _superHero.Attack + 20;
    public override int Defence => _superHero.Defence;
}

public class DeffenceDecorator : HeroDecorator
{
    public DeffenceDecorator(ISuperHero superHero) : base(superHero)
    {
    }

    public override int Attack => _superHero.Attack;
    public override int Defence => _superHero.Defence + 20;
}

public static class ClientCode
{
    public static void Test()
    {
        var superHero1 = new SuperHero();
        var superHero2 = new AttackDecorator(superHero1);
        var superHero3 = new AttackDecorator(superHero2);
        var superHero4 = new DeffenceDecorator(superHero3);

        Console.WriteLine(superHero1); // Attack: 50, Defence: 50
        Console.WriteLine(superHero2); // Attack: 70, Defence: 50
        Console.WriteLine(superHero3); // Attack: 90, Defence: 50
        Console.WriteLine(superHero4); // Attack: 90, Defence: 70
    }
}

