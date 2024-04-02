using System;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Components.WebAssembly.Hosting;


namespace P0006.Client
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            await builder.Build().RunAsync();
        }
    }
}
