using Application.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StockApp.Core.Application.Interfaces.Repositories;
using StockApp.Infrastructure.Persistence.Contexts;

namespace StockApp.Infrastructure.Persistence
{
    public static class ServiceRegistration
    {

        //Extension Method - Decorator
        public static void AddPersistenceInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            if (configuration.GetValue<bool>("UseInMemortDatabase"))
            {
                services.AddDbContext<ApplicationContext>(options => options.UseInMemoryDatabase("AplicationDB"));
            }
            else
            {

                services.AddDbContext<ApplicationContext>(options =>
                    options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                    m => m.MigrationsAssembly(typeof(ApplicationContext).Assembly.FullName)));
            }

            #region Repositories
            services.AddTransient(typeof(IGenericRepositoryAsync<>), typeof(GenericRepository<>));
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<ICategoryRepository, CategoryRepository>();
            #endregion
        }
    }
}
