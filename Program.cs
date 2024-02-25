using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ShoppingCart;
using ShoppingCart.Actions;
using ShoppingCart.Services;
using ShoppingCart.State;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<ICartService, CartService>();

builder.Services.AddSingleton<ICounterStateStore,CounterStateStore>();
builder.Services.AddSingleton<IPriceStateStore,TotalStateStore>();

//builder.Services.AddSingleton(typeof(ICounterStateStore<>),typeof(CounterStateStore<CounterState>));
//builder.Services.AddTransient(typeof(IDatabaseService<>), typeof(DatabaseService<>));

await builder.Build().RunAsync();
