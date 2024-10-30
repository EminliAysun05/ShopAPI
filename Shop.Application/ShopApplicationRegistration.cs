using Microsoft.Extensions.DependencyInjection;
using Shop.Application.Services.CategoryService;
using Shop.Application.Services.ProductService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application
{
    public static class ShopApplicationRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<ICategoryService, CategoryManager>();


            return services;
        }
    }
}
