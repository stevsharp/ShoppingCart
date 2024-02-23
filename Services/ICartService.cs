using ShoppingCart.Models;

namespace ShoppingCart.Services
{
    public interface ICartService
    {
        IList<Product> Cart { get; }
        int Total { get; }
        void AddProduct(Product product);
        void DeleteProduct(Product product);
    }
}
