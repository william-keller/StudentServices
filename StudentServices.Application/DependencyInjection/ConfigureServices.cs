using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace StudentServices.Application.DependencyInjection
{
    public static class ConfigureServices
    {
        public static void AddApplicationDependencyInjection(this IServiceCollection services)
        {
            services
                .AddMediatR(options => options.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
        }
    }
}
