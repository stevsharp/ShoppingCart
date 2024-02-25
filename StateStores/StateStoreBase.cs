using System.Reactive.Linq;
using System.Reactive.Subjects;

namespace ShoppingCart.StateStores
{
    public abstract class StateStoreBase<T> : IStateStoreBase<T> where T : class
    {
        protected BehaviorSubject<T> state;
        protected StateStoreBase() => state = new BehaviorSubject<T>(default(T)!);
        public IObservable<T> Value => state.AsObservable();
    }
}
