namespace ShoppingCart.Actions
{
    public interface IPriceStateStore
    {
        void Increment(decimal price);

        void Decrement(decimal price);
    }
}



