using Microsoft.AspNetCore.Components;

using ShoppingCart.Actions;

namespace ShoppingCart.Pages
{
    public partial class CounterSummary
    {

        private IDisposable? subscription;

        [Inject]
        public ICounterStateStore counterStateStoreActions { get; set; }

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
