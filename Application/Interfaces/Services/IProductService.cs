using StockApp.Core.Application.ViewModels.Product;

namespace StockApp.Core.Application.Interfaces.Services
{
    public interface IProductService : IGenericService<SaveProductViewModel, ProductViewModel>
    {
    }
}
