using ShoppingCart.Actions;
using ShoppingCart.Models;

namespace ShoppingCart.Services
{
    public class CartService : ICartService
    {
        private List<Product> cart = new();

        private int total;

        protected readonly CounterStateStore _counterStateStoreActions;

        protected readonly TotalStateStore _totalStateStore;
        public CartService(CounterStateStore counterStateStoreActions, TotalStateStore totalStateStore) 
        { 
            this._counterStateStoreActions = counterStateStoreActions; 

            this._totalStateStore = totalStateStore;
        }

        public IList<Product> Cart { get => cart; }
        public int Total{ get => total; }

        public void AddProduct(Product product)
        {
            cart.Add(product);

            total += product.Price;

            _totalStateStore.Increment(total);

            _counterStateStoreActions.Increment();

        }
        public void DeleteProduct(Product product)
        {
            cart.Remove(product);

            total -= product.Price;

            _totalStateStore.Increment(total);

            _counterStateStoreActions.Decrement();
        }
    }
}
