namespace Behavioral.ChainOfResponsibility
{
    public interface IHandler<T> where T : class
    {
        IHandler<T> SetNext(IHandler<T> handler);

        T Handle(T request);
    }

    abstract class HandlerBase<T> : IHandler<T> where T : class
    {
        private IHandler<T> _nextHandler;

        public IHandler<T> SetNext(IHandler<T> handler)
        {
            _nextHandler = handler;

            return handler;
        }

        public virtual T Handle(T request)
        {
            if (_nextHandler != null)
            {
                return _nextHandler.Handle(request);
            }
            else
            {
                return null;
            }
        }
    }

    class MinAgeHandler : HandlerBase<Order>
    {
        public override Order Handle(Order order)
        {
            if (order.GetUserAge() < 18)
            {
                throw new Exception("The user is under 18 years old.");
            }
            else
            {
                return base.Handle(order);
            }
        }
    }

    class MinAmountHandler : HandlerBase<Order>
    {
        public override Order Handle(Order order)
        {
            if (order.Amount < 20)
            {
                throw new Exception("The order amount does not reach the minimum order amount.");
            }
            else
            {
                return base.Handle(order);
            }
        }
    }

    class DiscountHandler : HandlerBase<Order>
    {
        public override Order Handle(Order order)
        {
            if (order.Amount > 100)
            {
                order.DiscountPercentage = 10;
            }

            return base.Handle(order);
        }
    }

    class ZipCodeHandler : HandlerBase<Order>
    {
        public readonly IEnumerable<string> ProhibitedZipCodes = new List<string>() 
        { 
            "9871",
            "8956",
            "8788"
        };

        public override Order Handle(Order order)
        {
            if (ProhibitedZipCodes.Contains(order.GetZipCode()))
            {
                throw new Exception("The zip code is on a blacklist.");
            }
            else
            {
                return base.Handle(order);
            }
        }
    }

    public class Address
    {
        public string ZipCode { get; set; }
    }

    public class User
    {
        public int Age { get; set; }
        public Address Address { get; set; }
    }

    public class Product
    {
        public double Price { get; set; }
    }

    public class Order
    {
        public User User { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public double DiscountPercentage { get; set; }
        public double Amount => Products.Sum(product => product.Price) * (100 - DiscountPercentage) / 100;

        public int GetUserAge() => User.Age;
        public string GetZipCode() => User.Address.ZipCode;
    }

    public interface IOrderService
    {
        Order CreateOrder(Order order);
    }

    // Client code:
    public class OrderService : IOrderService
    {
        private readonly IHandler<Order> _orderHandler;

        public OrderService(IHandler<Order> orderHandler)
        {
            _orderHandler = orderHandler;
        }

        public Order CreateOrder(Order order)
        {
            _orderHandler.Handle(order);
            // save order to DB

            return order;
        }
    }

    public static class Test
    {
        public static void UsePattern()
        {
            var user = new User()
            {
                Address = new Address { ZipCode = "1111" },
                Age = 18
            };

            var order = new Order()
            {
                User = user,
                Products = new List<Product>() { new Product { Price = 50 }, new Product { Price = 60 } }
            };

            IHandler<Order> minAgeHandler = new MinAgeHandler();
            IHandler<Order> minAmountHandler = new MinAmountHandler();
            IHandler<Order> discountHandler = new DiscountHandler();
            IHandler<Order> zipCodeHandler = new ZipCodeHandler();

            minAgeHandler
                .SetNext(minAmountHandler)
                .SetNext(minAgeHandler)
                .SetNext(discountHandler)
                .SetNext(zipCodeHandler);

            // I can give it any handler it will start with that.
            var orderService = new OrderService(minAgeHandler);
            var createdOrder = orderService.CreateOrder(order);

            Console.WriteLine(createdOrder.Amount);
        }
    }
}
