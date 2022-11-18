namespace Creational.FactoryMethod.Products
{
    public interface IPizza
    {
        IList<string> Toppings { get; }
        DoughType Dough { get; }
    }

    public class NormalPizza : IPizza
    {
        public NormalPizza(IList<string> toppings)
        {
            Toppings = toppings;
        }

        public IList<string> Toppings { get; }
        public DoughType Dough => DoughType.Normal;
    }

    public class NewYorkPizza : IPizza
    {
        public IList<string> Toppings { get; }
        public DoughType Dough => DoughType.Thin;

        public NewYorkPizza(IList<string> toppings)
        {
            Toppings = toppings;
        }
    }
    public class ChicagoPizza : IPizza
    {
        public IList<string> Toppings { get; }
        public DoughType Dough => DoughType.DeepDish;

        public ChicagoPizza(IList<string> toppings)
        {
            Toppings = toppings;
        }
    }

    public enum DoughType
    {
        Normal,
        Thin,
        DeepDish
    }
}
