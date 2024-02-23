using ShoppingCart;
using ShoppingCart.Actions;
using ShoppingCart.State;
using ShoppingCart.StateStores;

using System.Reactive.Subjects;

namespace ShoppingCart
{
    public class CounterStateStore: StateStoreBase<CounterState>, ICounterStateStore
    {
        public CounterStateStore() : base()
        {
            CounterState initialState = new CounterState(0);

            state = new BehaviorSubject<CounterState>(initialState);
        }

        public void Decrement()
        {
            var nextState = state.Value with { counter = state.Value.counter -1 };

            state.OnNext(nextState);
        }

        public void Increment()
        {
            var nextState = state.Value with { counter = state.Value.counter + 1 };

            state.OnNext(nextState);
        }
    }
}