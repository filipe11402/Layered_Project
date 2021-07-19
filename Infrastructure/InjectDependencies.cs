using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Project.Domain.Interfaces;
using Project.Domain.Repositories;
using Project.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Infrastructure
{
    public static class InjectDependencies
    {

        public static void AddInfrastructure(this IServiceCollection services) 
        {
            services.AddDbContext<ApplicationDbContext>(options 
                => options.UseSqlite(@"Data Source=C:\Users\Filipe Encarnacao\Desktop\C#\Domain_Layers\ProductDb"));
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IOrderRepository, OrderRepository>();
        }
    }
}
