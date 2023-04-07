namespace Creational.AbstractFactory
{
    public interface IPizza
    {
        string GetDescription();
    }

    public class ItalianPizza : IPizza
    {
        public string GetDescription()
        {
            return "Italian Pizza";
        }
    }

    public class AmericanPizza : IPizza
    {
        public string GetDescription()
        {
            return "American Pizza";
        }
    }

    public interface ICoffee
    {
        string GetDescription();
    }

    public class ItalianCofee : ICoffee
    {
        public string GetDescription()
        {
            return "Italian Cofee";
        }
    }

    public class AmericanCofee : ICoffee
    {
        public string GetDescription()
        {
            return "American Cofee";
        }
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

    // Használat:
    //var pizzaFactory = new ItalianPizzaFactory();
    //var coffeFactory = new AmericanCoffeeFactory();
    //var pizzaStore = new PizzaStore(pizzaFactory, coffeFactory);
    //IPizza pizza = pizzaStore.OrderPizza();
    //ICoffee coffee = pizzaStore.OrderCoffee();
    //Console.WriteLine(pizza.GetDescription()); // Italian Pizza
    //Console.WriteLine(coffee.GetDescription()); // American Cofee
}