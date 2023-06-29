namespace Structural.Composite;

// Component
public interface IProduct
{
    int Price { get; }
}

// Leafe
public class Product : IProduct
{
    public int Price { get; set; }
}

// Composite
public class ProductPackage : IProduct
{
    public required IEnumerable<Product> Products { get; set; }
    public int Price => Products.Sum(product => product.Price);
}

// Client code
public class ShoppingCart
{
    private readonly List<IProduct> _products = new();

    public int Amount => _products.Sum(product => product.Price);

    public void AddProduct(IProduct product) => _products.Add(product);
}


