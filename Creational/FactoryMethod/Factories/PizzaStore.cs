using Creational.FactoryMethod.Products;

namespace Creational.FactoryMethod.Factories
{
    public abstract class PizzaFactory
    {        
        public IPizza OrderPizza(IList<string> toppings)
        {
            IPizza pizza = CreatePizza(toppings);
            // Cut pizza
            // Box pizza
            return pizza;
        }
        public abstract IPizza CreatePizza(IList<string> toppings);
    }

    public class NormalPizzaStore : PizzaFactory
    {
        public override IPizza CreatePizza(IList<string> toppings)
        {
            return new NormalPizza(toppings);
        }
    }

    public class NewYorkPizzaStore : PizzaFactory
    {
        public override IPizza CreatePizza(IList<string> toppings)
        {
            return new NewYorkPizza(toppings);
        }
    }
    public class ChicagoPizzaStore : PizzaFactory
    {
        public override IPizza CreatePizza(IList<string> toppings)
        {
            return new ChicagoPizza(toppings);
        }
    }
}
