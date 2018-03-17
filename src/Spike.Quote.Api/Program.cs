using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;
using Spike.Extensions.Logging.Sql;

namespace Spike.Quote.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .ConfigureLogging((hostingContext, logging) =>
                {
                    logging.AddConfiguration(hostingContext.Configuration.GetSection("Logging"));
                    logging.AddConsole();
                    logging.AddDebug();
                    logging.AddSqlServer((_, logLevel) => logLevel >= LogLevel.Error, hostingContext.Configuration["SqlServerConnectionString"]);
                })
                .UseStartup<Startup>()
                .Build();
    }
}