namespace Creational.FactoryMethod
{
    public class Pizza
    {
        public PizzaDoughType DoughType { get; set; }

        public static Pizza CreateChicagoStylePizza => new() { DoughType = PizzaDoughType.DeepDish };
        public static Pizza CreateNewYorkStylePizza => new() { DoughType = PizzaDoughType.Thin };
    }

    public enum PizzaDoughType
    {
        Thin,
        DeepDish
    }
}
