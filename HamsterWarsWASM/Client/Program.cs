global using HamsterWarsWASM.Client.Services.HamsterService;
global using HamsterWarsWASM.Client.Services.MatchService;
global using HamsterWarsWASM.Shared.Entities;
global using HamsterWarsWASM.Shared.Service;
global using System.Net.Http.Json;
using Blazored.LocalStorage;
using HamsterWarsWASM.Client;
using HamsterWarsWASM.Client.Extensions;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddBlazoredLocalStorage();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.ConfigureServices(builder.Configuration);

await builder.Build().RunAsync();
