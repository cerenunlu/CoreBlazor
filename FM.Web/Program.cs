using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Blazored.SessionStorage;
namespace FM.Web
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

           // builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            var client = new HttpClient()
            {
                BaseAddress = new Uri("https://localhost:44320")
            };
            client.DefaultRequestHeaders.Add("Access-Control-Allow-Origin", "*");
            builder.Services.AddScoped(sp => client);
            builder.Services.AddBlazoredSessionStorage();
            await builder.Build().RunAsync();
        }
    }
}
