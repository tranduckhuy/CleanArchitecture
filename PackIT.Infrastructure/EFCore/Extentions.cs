using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PackIT.Application.Services;
using PackIT.Domain.Repositories;
using PackIT.Infrastructure.EFCore.Context;
using PackIT.Infrastructure.EFCore.Options;
using PackIT.Infrastructure.EFCore.Repositories;
using PackIT.Infrastructure.EFCore.Services;
using PackIT.Shared.Options;

namespace PackIT.Infrastructure.EFCore
{
    public static class Extentions
    {
        public static IServiceCollection AddSQLite(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IPackingListRepository, SQLitePackingListRepository>();
            services.AddScoped<IPackingListReadService, SQLitePackingListReadService>();


            var sqliteOptions = configuration.GetOptions<SQLiteOptions>("SQLite");
            services.AddDbContext<ReadDbContext>(options => options.UseSqlite(sqliteOptions.ConnectionString,
                b => b.MigrationsAssembly("PackIT.Infrastructure")));

            services.AddDbContext<WriteDbContext>(options => options.UseSqlite(sqliteOptions.ConnectionString,
                b => b.MigrationsAssembly("PackIT.Infrastructure")));

            return services;
        }
    }
}
