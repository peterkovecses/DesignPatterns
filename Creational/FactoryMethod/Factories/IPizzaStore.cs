using Creational.FactoryMethod.Products;

namespace Creational.FactoryMethod.Factories
{
    public interface IPizzaStore
    {        
        IPizza OrderPizza(IList<string> toppings, DoughType dough);
    }

    public class PizzaStore : IPizzaStore
    {
        public IPizza OrderPizza(IList<string> toppings, DoughType dough)
        {
            return dough switch
            {
                DoughType.Thin => CreateNewYorkPizza(toppings),
                DoughType.DeepDish => CreateChicagoPizza(toppings),
                _ => CreateNormalPizza(toppings)
            };
        }

        private static NormalPizza CreateNormalPizza(IList<string> toppings)
        {
            return new NormalPizza(toppings);
        }

        private static NewYorkPizza CreateNewYorkPizza(IList<string> toppings)
        {
            return new NewYorkPizza(toppings);
        }

        private static ChicagoPizza CreateChicagoPizza(IList<string> toppings)
        {
            return new ChicagoPizza(toppings);
        }
    }
}
