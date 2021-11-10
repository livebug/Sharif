using Blog.BlazorApp;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Services.Hexo;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Services
builder.Services.AddLogging();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<HexoService>();
// Config
var host = builder.Build();
var hexoService = host.Services.GetRequiredService<HexoService>();
await hexoService.InitHexoContentAsync(@"sample-data\hexodb.json");

await host.RunAsync();

