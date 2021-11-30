using Blog.BlazorApp;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Logging;
using Services.Hexo;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Services
builder.Logging.AddConfiguration(builder.Configuration.GetSection("Logging"));
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddHttpClient("GithubLookApi", client =>
{
    client.BaseAddress = new Uri("https://api.github.com/");
    client.DefaultRequestHeaders.Add("Accept", "application/vnd.github.v3+json");
    client.DefaultRequestHeaders.Add("Authorization", $"token {builder.Configuration["GithubLookApi_Token"]}");
});
builder.Services.AddScoped<HexoService>();
// Config
var host = builder.Build();
var hexoService = host.Services.GetRequiredService<HexoService>();
await hexoService.InitHexoContentAsync(@"sample-data\hexodb.json");

await host.RunAsync();


