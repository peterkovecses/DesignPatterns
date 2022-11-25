using Creational.FactoryMethod.Products;

namespace Creational.FactoryMethod.Factories
{
    public abstract class PizzaFactory
    {        
        public IPizza OrderPizza(IList<string> toppings)
        {
            IPizza pizza = CreatePizza(toppings);
            // Bake pizza
            // Cut pizza
            // Box pizza
            return pizza;
        }
        protected abstract IPizza CreatePizza(IList<string> toppings);
    }

    public class NormalPizzaStore : PizzaFactory
    {
        protected override IPizza CreatePizza(IList<string> toppings)
        {
            return new NormalPizza(toppings);
        }
    }

    public class NewYorkPizzaStore : PizzaFactory
    {
        protected override IPizza CreatePizza(IList<string> toppings)
        {
            return new NewYorkPizza(toppings);
        }
    }
    public class ChicagoPizzaStore : PizzaFactory
    {
        protected override IPizza CreatePizza(IList<string> toppings)
        {
            return new ChicagoPizza(toppings);
        }
    }
}
