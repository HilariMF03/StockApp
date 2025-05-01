using StockApp.Core.Application.Interfaces.Repositories;
using StockApp.Core.Application.Interfaces.Services;
using StockApp.Core.Application.ViewModels.Product;
using StockApp.Core.Domain.Entities;

namespace Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;

        }

        public async Task Update(SaveProductViewModel vm)
        {
            Product product = new();
            product.Id = vm.Id;
            product.Name = vm.Name;
            product.Description = vm.Description;
            product.Price = vm.Price;
            product.Id = vm.Id;
            product.CategoryId = vm.CategoryId;
            product.ImagUrl = vm.ImagUrl;

            await _productRepository.UpdateAsync(product);

        }

        public async Task Add(SaveProductViewModel vm)
        {
            Product product = new();
            product.Name = vm.Name;
            product.Description = vm.Description;
            product.Price = vm.Price;
            product.Id = vm.Id;
            product.CategoryId = vm.CategoryId;
            product.ImagUrl = vm.ImagUrl;

            await _productRepository.AddAsync(product);

        }

        public async Task Delete(int id)
        {
            var product = await _productRepository.GetByIdAsync(id);
            await _productRepository.DeleteAsync(product);
        }

        public async Task<SaveProductViewModel> GetByIdSaveViewModel(int id)
        {
            var product = await _productRepository.GetByIdAsync(id);

            SaveProductViewModel vm = new();
            vm.Id = id;
            vm.Name = product.Name;
            vm.Description = product.Description;
            vm.Price = product.Price;
            vm.ImagUrl = product.ImagUrl;
            return vm;
        }


        public async Task<List<ProductViewModel>> GetAllViewModel()
        {
            var productList = await _productRepository.GetAllAsync();
            return productList.Select(product => new ProductViewModel
            {
                Name = product.Name,
                Description = product.Description,
                Id = product.Id,
                ImagUrl = product.ImagUrl,
                Price = product.Price

            }).ToList();

        }


    }
}
