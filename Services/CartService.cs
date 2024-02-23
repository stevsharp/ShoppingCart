using ShoppingCart.Models;

namespace ShoppingCart.Services
{
    public class CartService : ICartService
    {
        private List<Product> cart = new();

        private int total;

        protected readonly CounterStateStore counterStateStoreActions;
        public CartService(CounterStateStore counterStateStoreActions) => this.counterStateStoreActions = counterStateStoreActions;

        public IList<Product> Cart { get => cart; }
        public int Total{ get => total; }

        public void AddProduct(Product product)
        {
            cart.Add(product);

            total += product.Price;

            counterStateStoreActions.Increment();

        }
        public void DeleteProduct(Product product)
        {
            cart.Remove(product);

            total -= product.Price;

            counterStateStoreActions.Decrement();
        }
    }
}
