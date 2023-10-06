using DataAccess.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace StudyTracker
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //var builder = new ConfigurationBuilder()
            //     .AddJsonFile($"appsettings.json", true, true);

            //var config = builder.Build();


            var services = new ServiceCollection();
            services.AddTransient<IActivityRepository, ActivityRepository>();
            var serviceProvider = services.BuildServiceProvider();


            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm(serviceProvider));
        }
    }
}