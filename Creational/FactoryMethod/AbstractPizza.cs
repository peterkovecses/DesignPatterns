namespace Creational.FactoryMethod
{
    public interface IPizza
    {
        string Description { get; }
    }

    public class MargeritaPizza : IPizza
    {
        public string Description => "Margerita Pizza";
    }

    public class PepperoniPizza : IPizza
    {
        public string Description => "Pepperoni Pizza";
    }

    public class PizzaFactory
    {
        public static IPizza CreatePizza(PizzaType type)
        {
            return type switch
            {
                PizzaType.Margerita => new MargeritaPizza(),
                PizzaType.Pepperoni => new PepperoniPizza(),
                _ => throw new ArgumentException($"Invalid pizza type: {type}")
            };
        }
    }

    public enum PizzaType
    {
        Margerita,
        Pepperoni
    }

    // Client code:
    //var random = new Random();
    //var randomPizza = random.Next(0, 2) == 0 ? PizzaFactory.CreatePizza(PizzaType.Margerita)
    //    : PizzaFactory.CreatePizza(PizzaType.Pepperoni);
    //Console.WriteLine(randomPizza.Description);
}
