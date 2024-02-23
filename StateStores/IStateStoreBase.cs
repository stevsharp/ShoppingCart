
namespace ShoppingCart.StateStores
{
    public interface IStateStoreBase<T> where T : new()
    {
        IObservable<T> Value { get; }
    }
}