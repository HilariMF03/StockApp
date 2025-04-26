using StockApp.Core.Domain.Entities;

namespace StockApp.Core.Application.Interfaces.Repositories
{
    public interface IProductRepository
    {
        Task AddAsync(Product product);
        Task UpdateAsync(Product product);
        Task DeleteAsync(Product product);
        Task<List<Product>> GetAllAsync();
        Task<Product> GetByIdAsync(int id);

    }
}
