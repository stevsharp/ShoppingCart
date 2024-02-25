using ShoppingCart.State;
using ShoppingCart.StateStores;

namespace ShoppingCart.Actions
{

    public interface ICounterStateStore : IStateStoreBase<CounterState>
    {
        void Increment();

        void Decrement();
    }
}



