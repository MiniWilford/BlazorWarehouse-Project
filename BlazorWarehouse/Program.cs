using BlazorWarehouse;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Connect to WebAPI library, not Blazor
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7180") });

await builder.Build().RunAsync();
