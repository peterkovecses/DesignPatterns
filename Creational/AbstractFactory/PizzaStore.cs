namespace Creational.AbstractFactory
{
    public interface IPizza
    {
        string Description { get; }
    }

    public class ItalianPizza : IPizza
    {
        public string Description => "Italian Pizza";
    }

    public class AmericanPizza : IPizza
    {
        public string Description => "American Pizza";
    }

    public interface ICoffee
    {
        string Description { get; }
    }

    public class ItalianCofee : ICoffee
    {
        public string Description => "Italian Cofee";
    }

    public class AmericanCofee : ICoffee
    {
        public string Description => "American Cofee";
    }

    public interface IPizzaFactory
    {
        IPizza CreatePizza();
    }

    public interface ICoffeeFactory
    {
        ICoffee CreateCoffee();
    }

    public class ItalianPizzaFactory : IPizzaFactory
    {
        public IPizza CreatePizza()
        {
            return new ItalianPizza();
        }
    }

    public class ItalianCoffeeFactory : ICoffeeFactory
    {
        public ICoffee CreateCoffee()
        {
            return new ItalianCofee();
        }
    }

    public class AmericanPizzaFactory : IPizzaFactory
    {
        public IPizza CreatePizza()
        {
            return new AmericanPizza();
        }
    }

    public class AmericanCoffeeFactory : ICoffeeFactory
    {
        public ICoffee CreateCoffee()
        {
            return new AmericanCofee();
        }
    }

    // Client code:
    public class PizzaStore
    {
        private readonly IPizzaFactory _pizzaFactory;
        private readonly ICoffeeFactory _coffeeFactory;

        public PizzaStore(IPizzaFactory pizzaFactory, ICoffeeFactory coffeeFactory)
        {
            _pizzaFactory = pizzaFactory;
            _coffeeFactory = coffeeFactory;
        }

        public IPizza OrderPizza()
        {
            return _pizzaFactory.CreatePizza();
        }

        public ICoffee OrderCoffee()
        {
            return _coffeeFactory.CreateCoffee();
        }        
    }

    public static class ClientCode
    {
        public static void Test()
        {
            var pizzaStore = new PizzaStore(new ItalianPizzaFactory(), new AmericanCoffeeFactory());

            IPizza pizza = pizzaStore.OrderPizza();
            ICoffee coffee = pizzaStore.OrderCoffee();

            Console.WriteLine(pizza.Description); // Italian Pizza
            Console.WriteLine(coffee.Description); // American Cofee
        }
    }    
}

