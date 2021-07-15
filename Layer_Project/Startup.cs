using Application.Queries;
using Application.Queries.Interfaces;
using Application.ViewModels;
using AutoMapper;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Project.Domain.Commands;
using Project.Domain.Entities;
using Project.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Layer_Project
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddInfrastructure();
            services.InfrastructureServices();
            services.AddControllersWithViews();
            services.AddScoped<IGetProductListQuery, GetProductListQuery>();
            services.AddScoped<IGetOrderListQuery, GetOrderListQuery>();

            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Product, ProductViewModel>();
                cfg.CreateMap<ProductViewModel, CreateProductCommand>();
                cfg.CreateMap<ProductViewModel, Product>();
                cfg.CreateMap<Order, OrderViewModel>();
                //cfg.CreateMap<OrderProduct, Order>();
            });

            IMapper mapper = configuration.CreateMapper();
            services.AddSingleton(mapper);
            services.AddMediatR(typeof(ProductViewModel).Assembly, typeof(CreateProductCommand).Assembly);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
