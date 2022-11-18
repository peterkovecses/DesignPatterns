using Creational.AbstractFactory.Products;

namespace Creational.AbstractFactory.Factories
{
    public abstract class PizzaFactory
    {
        public abstract IPizza CreatePizza(IList<string> toppings);
    }

    public class NormalPizzaFactory : PizzaFactory
    {
        public override IPizza CreatePizza(IList<string> toppings)
        {
            return new NormalPizza(toppings);
        }
    }

    public class NewYorkPizzaFactory : PizzaFactory
    {
        public override IPizza CreatePizza(IList<string> toppings)
        {
            return new NewYorkPizza(toppings);
        }
    }
    public class ChicagoPizzaFactory : PizzaFactory
    {
        public override IPizza CreatePizza(IList<string> toppings)
        {
            return new ChicagoPizza(toppings);
        }
    }
}
