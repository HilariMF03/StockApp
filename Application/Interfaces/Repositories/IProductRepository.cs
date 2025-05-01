using StockApp.Core.Domain.Entities;

namespace StockApp.Core.Application.Interfaces.Repositories
{
    public interface IProductRepository : IGenericRepositoryAsync<Product>
    {
    }
}
