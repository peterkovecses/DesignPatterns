namespace Structural.Decorator.Example2
{
    public interface IOrder
    {        
        List<Product> Products { get; }

        decimal GetSubtotal();
        decimal GetShippingCost();
        decimal GetTotalAmmount();
    }

    public class Order : IOrder
    {
        private const int _baseShippingCost = 15;
        public List<Product> Products { get; } = new();

        public decimal GetSubtotal() => Products.Sum(p => p.Price);

        public decimal GetShippingCost() => _baseShippingCost;

        public decimal GetTotalAmmount() => GetSubtotal() + GetShippingCost();
    }

    public abstract class OrderDecoratorBase : IOrder
    {
        protected readonly IOrder _order;
        protected const decimal ExpressExtraCharge = 15;

        public OrderDecoratorBase(IOrder order)
        {
            _order = order;
        }

        public List<Product> Products => _order.Products;

        public virtual decimal GetSubtotal() => _order.GetSubtotal();

        public virtual decimal GetShippingCost() => _order.GetShippingCost();

        public virtual decimal GetTotalAmmount() => GetSubtotal() + GetShippingCost();
    }

    public class OrderExpressDecorator : OrderDecoratorBase
    {
        public OrderExpressDecorator(Order order) : base(order)
        {
        }

        public override decimal GetShippingCost() => _order.GetShippingCost() + ExpressExtraCharge;

    }

    public class Product
    {
        public int Price { get; set; }
    }
}
