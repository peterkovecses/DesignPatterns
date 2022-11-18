namespace Creational.AbstractFactory.Products
{
    public interface IPizza
    {
        IList<string> Toppings { get; }
        PizzaDoughType Dough { get; }
    }

    public class NormalPizza : IPizza
    {
        public NormalPizza(IList<string> toppings)
        {
            Toppings = toppings;
        }

        public IList<string> Toppings { get; }
        public PizzaDoughType Dough => PizzaDoughType.Normal;
    }

    public class NewYorkPizza : IPizza
    {
        public IList<string> Toppings { get; }
        public PizzaDoughType Dough => PizzaDoughType.Thin;

        public NewYorkPizza(IList<string> toppings)
        {
            Toppings = toppings;
        }
    }
    public class ChicagoPizza : IPizza
    {
        public IList<string> Toppings { get; }
        public PizzaDoughType Dough => PizzaDoughType.DeepDish;

        public ChicagoPizza(IList<string> toppings)
        {
            Toppings = toppings;
        }
    }

    public enum PizzaDoughType
    {
        Normal,
        Thin,
        DeepDish
    }
}
