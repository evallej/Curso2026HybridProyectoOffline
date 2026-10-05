using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using PedidoNetWeb;
using PedidoNetWeb.Models.Auth;
using PedidoNetWeb.Services;
using PedidoNetWeb.Services.Api;
using PedidoNetWeb.Services.Productos;
using PedidoNetUIShared.Offline.Productos;
using PedidoNetWeb.Services.Offline;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

var apiBaseUrl = builder.Configuration["ApiBaseUrl"]
    ?? throw new InvalidOperationException("ApiBaseUrl no está configurado");

builder.Services.AddScoped(sp => new HttpClient { 
    //BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
    BaseAddress=new Uri(apiBaseUrl)
});

builder.Services.AddScoped<AuthApiClient>();

builder.Services.AddScoped<ITokenStorage, TokenStorage>();

builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<ProductosApiClient>();
builder.Services.AddScoped<IProductoService, ProductoService>();
builder.Services.AddScoped<ConnectivityService>();
builder.Services.AddScoped<IProductoOfflineStore, IndexedDbProductoStore>();
builder.Services.AddScoped<IProductoSyncQueue, IndexedDbProductoSyncQueue>();
builder.Services.AddScoped<ProductoSyncService>();

await builder.Build().RunAsync();
