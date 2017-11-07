
using Microsoft.AspNetCore.Hosting;
using WebTest;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseStartup<StartUp>()
                .Build();
             host.Run();
        }
    }
}
