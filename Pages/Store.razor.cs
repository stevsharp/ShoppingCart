using Microsoft.AspNetCore.Components;

using ShoppingCart.Actions;
using ShoppingCart.Models;
using ShoppingCart.State;

using System.Net.Http.Json;

namespace ShoppingCart.Pages
{
    public partial class Store
    {
        public IList<Product>? products;

        protected override async Task OnInitializedAsync()
        {
            products = await Http.GetFromJsonAsync<Product[]>("sample-data/products.json");
        }

    }
}
