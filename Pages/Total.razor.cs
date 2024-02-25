using Microsoft.AspNetCore.Components;

using ShoppingCart.Actions;

namespace ShoppingCart.Pages
{
    public partial class Total
    {
        private IDisposable? subscription;

        [Inject]
        public IPriceStateStore totalStateStore { get; set; }

        protected decimal total = 0;

        protected override void OnInitialized()
        {
            this.subscription = this.totalStateStore.Value
             .Subscribe((state) =>
             {
                 total = state.price;

                 StateHasChanged();
             });
        }

        public void Dispose()
        {
            subscription?.Dispose();
        }
    }
}
