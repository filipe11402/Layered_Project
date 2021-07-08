using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Infrastructure
{
    public static class InfrastructureDependencies
    {

        public static void AddInfrastructure(this IServiceCollection services) 
        {
            services.AddScoped(typeof(IApplicationDbContext), typeof(ApplicationDbContext));
            services.AddDbContext<ApplicationDbContext>(options 
                => options.UseSqlite(@"Data Source=C:\Users\Filipe Encarnacao\Desktop\C#\Layer_Project\ProductDb"));
        }
    }
}
