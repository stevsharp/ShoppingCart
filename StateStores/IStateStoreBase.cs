
namespace ShoppingCart.StateStores
{
    public interface IStateStoreBase<T> where T : class
    {
        IObservable<T> Value { get; }
    }
}