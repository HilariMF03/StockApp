using Application.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StockApp.Core.Application.Interfaces.Services;


namespace StockApp.Infrastructure.Persistence
{
    public static class ServiceRegistration
    {

        //Extension Method - Decorator
        public static void AddApplicationLayer(this IServiceCollection services, IConfiguration configuration)
        {

            #region Services
            services.AddTransient<IProductService, ProductService>();
            #endregion
        }
    }
}
