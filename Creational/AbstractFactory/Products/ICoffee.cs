namespace Creational.AbstractFactory.Products
{
    public class ICoffee
    {
    }

    public class NormalCoffee : ICoffee
    {
    }

    public class AmericanCoffee : ICoffee
    {
    }

    public class ItalianCoffee : ICoffee
    {
    }

    public enum CoffeeStyle
    {
        Normal,
        American,
        Italian
    }
}
