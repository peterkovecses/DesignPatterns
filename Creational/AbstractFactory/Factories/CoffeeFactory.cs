using Creational.AbstractFactory.Products;

namespace Creational.AbstractFactory.Factories
{
    public abstract class CoffeeFactory
    {
        public abstract ICoffee CreateCoffee();
    }

    public class NormalCoffeeFactory : CoffeeFactory
    {
        public override ICoffee CreateCoffee()
        {
            return new NormalCoffee();
        }
    }

    public class AmericanCoffeeFactory : CoffeeFactory
    {
        public override ICoffee CreateCoffee()
        {
            return new AmericanCoffee();
        }
    }

    public class ItalianCoffeeFactory : CoffeeFactory
    {
        public override ICoffee CreateCoffee()
        {
            return new ItalianCoffee();
        }
    }
}
