using GoldenPaths.Domain.Interfaces.Repositories;
using GoldenPaths.Infraestructure;
using GoldenPaths.Infraestructure.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GoldenPaths.CrossCutting.Config
{
    public static class InfraConfigurations
    {
        public static void AddInfraConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<GPContext>(context => context.UseSqlServer(connectionString));

            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
