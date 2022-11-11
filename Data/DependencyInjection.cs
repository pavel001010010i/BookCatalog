using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Application;
using Application.Interfaces;

namespace Data
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddData(this IServiceCollection services,
           IConfiguration configuration) 
        {
            services.AddDbContext<DBContext>(opts =>
                  opts.UseSqlServer(configuration.GetConnectionString("sqlConnection"), b =>
                  b.MigrationsAssembly("Data")));

            services.AddScoped<IDBContext>(provider =>
                    provider.GetService<DBContext>());

            return services;
        }
    }
}
