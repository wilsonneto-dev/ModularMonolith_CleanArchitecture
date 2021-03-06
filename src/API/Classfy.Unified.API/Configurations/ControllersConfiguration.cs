using Classfy.Unified.API.Filters;

namespace Classfy.Unified.API.Configurations
{
    public static class ControllersConfiguration
    {
        public static IServiceCollection AddControllersAndConfigure(this IServiceCollection services)
        {
            services.AddControllers(options => options.Filters.Add(typeof(ValidationFilter)));
            return services;
        }
    }
}
