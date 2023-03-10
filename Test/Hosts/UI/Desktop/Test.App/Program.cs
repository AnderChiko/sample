using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Test.BusinessLogic;
using Test.Context;

namespace Test.App
{
    internal static class Program
    {

        public static IConfiguration Configuration { get; }

        public static ServiceProvider serviceProvider { get; private set; }


        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {


            // Setup Host
            var host = CreateDefaultBuilder().Build();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }

        static IHostBuilder CreateDefaultBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureAppConfiguration((hostContext, configBuilder) =>
                {
                    configBuilder.SetBasePath(Directory.GetCurrentDirectory());
                    configBuilder.AddJsonFile("appsettings.json");
                    configBuilder.Build();
                })
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddContextIoC();
                    services.AddBusinessLogicIOC();
                    services.AddOptions();

                    services.AddContextOptions(Configuration);
                });
        }


    }
}