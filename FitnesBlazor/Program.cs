using FitnesBlazor;
using FitnesBlazor.ApiRequests.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri("https://localhost:7043/")
});

builder.Services.AddScoped<UserApiService>();
builder.Services.AddScoped<AbonementApiService>();
builder.Services.AddScoped<CourtApiService>();
builder.Services.AddScoped<BookingApiService>();
builder.Services.AddScoped<SectionApiService>();
builder.Services.AddScoped<InventoryApiService>();
builder.Services.AddScoped<EventApiService>();
builder.Services.AddScoped<AnalyticsApiService>();
builder.Services.AddScoped<AccessControlService>();


builder.Services.AddScoped<AuthStateService>();
builder.Services.AddScoped<AccessControlService>();

await builder.Build().RunAsync();