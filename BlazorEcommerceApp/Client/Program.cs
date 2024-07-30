global using BlazorEcommerceApp.Shared;
global using System.Net.Http.Json;
global using BlazorEcommerceApp.Client.Services.ProductService;
global using BlazorEcommerceApp.Client.Services.CategoryService;
using BlazorEcommerceApp.Client;
using BlazorEcommerceApp.Client.Shared;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();

await builder.Build().RunAsync();
