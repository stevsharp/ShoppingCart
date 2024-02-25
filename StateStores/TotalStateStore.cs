using ShoppingCart.Actions;
using ShoppingCart.State;
using ShoppingCart.StateStores;

using System.Reactive.Subjects;

namespace ShoppingCart
{
    public class TotalStateStore : StateStoreBase<PriceState>, IPriceStateStore
    {
        public TotalStateStore() : base()
        {
            PriceState priceState = new PriceState(0);

            state = new BehaviorSubject<PriceState>(priceState);
        }

        public void Decrement(decimal price)
        {
            state.OnNext(new PriceState(price));
        }

        public void Increment(decimal price)
        {
            state.OnNext(new PriceState(price));
        }
    }
}