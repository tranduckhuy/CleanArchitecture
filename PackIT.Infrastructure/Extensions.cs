using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PackIT.Application.Services;
using PackIT.Infrastructure.EFCore;
using PackIT.Infrastructure.EFCore.Options;
using PackIT.Infrastructure.Services;
using PackIT.Shared.Options;
using PackIT.Shared.Queries;

namespace PackIT.Infrastructure
{
    public static class Extensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSQLite(configuration);
            services.AddQueries();
            services.AddSingleton<IWeatherSerivce, DumbWeatherService>();

            return services;
        }
    }
}
