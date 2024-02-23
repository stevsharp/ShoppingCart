using Microsoft.AspNetCore.Components;

namespace ShoppingCart.Pages
{
    public partial class Summary
    {

        private IDisposable? subscription;

        [Inject]
        public CounterStateStore counterStateStoreActions { get; set; }

        protected int currentCount = 0;

        protected override void OnInitialized()
        {
            this.subscription = this.counterStateStoreActions.Value
             .Subscribe((state) =>
             {
                 currentCount = state.counter;

                 StateHasChanged();

             });
        }

        public void Dispose()
        {
            subscription?.Dispose();
        }
    }
}
