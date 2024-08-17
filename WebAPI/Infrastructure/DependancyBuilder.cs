using Microsoft.AspNetCore.Identity;
using WebAPI_Data;
using WebAPI_Data_Contract;
using WebAPI_Domain;
using WebAPI_Domain_Contract;

namespace WebAPI.Infrastructure
{
    public class DependancyBuilder
    {
        public static void BuildDependency(IServiceCollection services)
        {

            AddScopedDependencies(services);
            AddTransientDependencies(services);
        }

        private static void AddTransientDependencies(IServiceCollection services)
        {
            services.AddTransient<IDemoManager, DemoManager>();
            services.AddTransient<INotificationManager, NotificationManager>();
        }

        private static void AddScopedDependencies(IServiceCollection services)
        {
            services.AddScoped<IDemoRepository, DemoRepository>();
        }
    }
}
