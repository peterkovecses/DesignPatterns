namespace Structural.Decorator2
{
    public interface IOrder
    {
        List<string> Products { get; }

        decimal GetSubtotal();
        decimal GetShippingCost();
        decimal GetTotalAmmount();        
    }

    public class Order : IOrder
    {
        public List<string> Products { get; } = new List<string>();

        public decimal GetSubtotal()
        {
            // return Products.Sum(p => p.Price);
            throw new NotImplementedException();
        }

        public decimal GetShippingCost() => 15;

        public decimal GetTotalAmmount() => GetSubtotal() + GetShippingCost();
    }

    public abstract class OrderDecoratorBase : IOrder
    {
        protected readonly Order _order;
        protected const decimal ExpressExtraCharge = 15;

        public OrderDecoratorBase(Order order)
        {
            _order = order;
        }

        public List<string> Products { get => _order.Products; }

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
}
