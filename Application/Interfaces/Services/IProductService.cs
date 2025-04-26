using StockApp.Core.Application.ViewModels.Product;

namespace StockApp.Core.Application.Interfaces.Services
{
    public interface IProductService
    {
        Task Update(SaveProductViewModel vm);
        Task Add(SaveProductViewModel vm);
        Task Delete(int id);
        Task<SaveProductViewModel> GetByIdSaveViewModel(int id);
        Task<List<ProductViewModel>> GetAllViewModel();
    }
}
