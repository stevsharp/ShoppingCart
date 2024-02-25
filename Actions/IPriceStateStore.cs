using ShoppingCart.State;
using ShoppingCart.StateStores;

namespace ShoppingCart.Actions
{
    public interface IPriceStateStore : IStateStoreBase<PriceState>
    {
        void Increment(decimal price);

        void Decrement(decimal price);
    }
}



