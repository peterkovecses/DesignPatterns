namespace Structural.Composite
{
    public interface IProduct
    {
        int Price { get; }
    }

    public class Product : IProduct
    {
        public int Price { get; set; }
    }

    public class ProductPackage : IProduct
    {
        public required IEnumerable<Product> Products { get; set; }
        public int Price => Products.Sum(product => product.Price);
    }
}


