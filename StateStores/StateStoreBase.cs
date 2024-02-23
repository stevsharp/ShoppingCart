using System.Reactive.Linq;
using System.Reactive.Subjects;

namespace ShoppingCart.StateStores
{
    public abstract class StateStoreBase<T> where T : class
    {
        protected BehaviorSubject<T> state;
        public StateStoreBase() => state = new BehaviorSubject<T>(default(T)!);
        public IObservable<T> Value => state.AsObservable();
    }
}
