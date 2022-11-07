using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Application;

namespace Data
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddData(this IServiceCollection services,
           IConfiguration configuration)
        {
            services.AddDbContext<DataContext>(opts =>
                  opts.UseSqlServer(configuration.GetConnectionString("sqlConnection")));

            return services;
        }
    }
}
