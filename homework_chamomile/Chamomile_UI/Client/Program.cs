using Chamomile_UI;
using Chamomile_UI.States;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace Chamomile_UI
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7056/") });
            builder.Services.AddScoped<ChoosedTableState>();
            builder.Services.AddScoped<AddBrandState>();

            await builder.Build().RunAsync();
        }
    }
}
