namespace StockApp.Core.Application.Interfaces.Services
{
    public interface IGenericService<SaveViewModel, ViewModel>
        where SaveViewModel : class
        where ViewModel : class //toma 2 porque el ultimo metodo no espera un save sino un viewmodel y los generic pueden resivir mas de 1tipo
    {
        Task Update(SaveViewModel vm);
        Task Add(SaveViewModel vm);
        Task Delete(int id);
        Task<SaveViewModel> GetByIdSaveViewModel(int id);
        Task<List<ViewModel>> GetAllViewModel();
    }
}
