namespace Creational.FactoryMethod
{
    public class SimplePizza
    {
        public PizzaDoughType DoughType { get; set; }

        public static SimplePizza CreateChicagoStylePizza() => new() { DoughType = PizzaDoughType.DeepDish };
        public static SimplePizza CreateNewYorkStylePizza() => new() { DoughType = PizzaDoughType.Thin };
    }
}
