using GoldenPaths.ApplicationCore.Services;
using GoldenPaths.Domain.Interfaces.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenPaths.CrossCutting.Config
{
    public static class ServicesConfigurations
    {
        public static void AddServiceConfiguration(this IServiceCollection services)
        {
            services.AddScoped<IAccountManager, AccountManager>();
        }
    }
}
