using Creational.AbstractFactory.Factories;
using Creational.AbstractFactory.Products;

namespace Creational.AbstractFactory
{
    public class PizzaStore
    {
        private readonly PizzaFactory _pizzaFactory;
        private readonly CoffeeFactory _coffeeFactory;

        public PizzaStore(PizzaDoughType pizzaDoughType, CoffeeStyle coffeeStyle)
        {
            _pizzaFactory = CreatePizzaFactory(pizzaDoughType);
            _coffeeFactory = CreateCoffeeFactory(coffeeStyle);
        }

        public IPizza OrderPizza(IList<string> toppings)
        {
            var pizza = _pizzaFactory.CreatePizza(toppings);
            // Bake pizza
            // Cut pizza
            // Box pizza
            return pizza;
        }

        public ICoffee OrderCoffee()
        {
            var coffee = _coffeeFactory.CreateCoffee();
            // Box coffee
            return coffee;
        }

        private static PizzaFactory CreatePizzaFactory(PizzaDoughType pizzaDoughType)
        {
            return pizzaDoughType switch
            {
                PizzaDoughType.Thin => new NewYorkPizzaFactory(),
                PizzaDoughType.DeepDish => new ChicagoPizzaFactory(),
                _ => new NormalPizzaFactory()
            };
        }

        private static CoffeeFactory CreateCoffeeFactory(CoffeeStyle coffeeStyle) 
        {
            return coffeeStyle switch
            {
                CoffeeStyle.American => new AmericanCoffeeFactory(),
                CoffeeStyle.Italian => new ItalianCoffeeFactory(),
                _ => new NormalCoffeeFactory()
            };
        }
    }
}
