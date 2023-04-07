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

    public interface IFoodFactory
    {
        IPizza CreatePizza();
        ICoffee CreateCoffee();
    }

    public class ItalianFoodFactory : IFoodFactory
    {
        public IPizza CreatePizza()
        {
            return new ItalianPizza();
        }

        public ICoffee CreateCoffee()
        {
            return new ItalianCofee();
        }
    }

    public class AmericanFoodFactory : IFoodFactory
    {
        public IPizza CreatePizza()
        {
            return new AmericanPizza();
        }

        public ICoffee CreateCoffee()
        {
            return new AmericanCofee();
        }
    }

    // Client code:
    public class FoodOrderService
    {
        private readonly IFoodFactory _foodFactory;

        public FoodOrderService(IFoodFactory foodFactory)
        {
            _foodFactory = foodFactory;
        }

        public IPizza OrderPizza()
        {
            return _foodFactory.CreatePizza();
        }

        public ICoffee OrderCoffee()
        {
            return _foodFactory.CreateCoffee();
        }        
    }

    // Használat:
    //var foodFactory = new ItalianFoodFactory();
    //var foodOrderService = new FoodOrderService(foodFactory);
    //IPizza pizza = foodOrderService.OrderPizza();
    //ICoffee coffee = foodOrderService.OrderCoffee();
    //Console.WriteLine(pizza.GetDescription()); // Italian Pizza
    //Console.WriteLine(coffee.GetDescription()); // Italian Cofee
}