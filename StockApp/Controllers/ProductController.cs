using Application.Services;
using Application.ViewModels;
using Database;
using Microsoft.AspNetCore.Mvc;

namespace StockApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductService _productService;

        public ProductController(ApplicationContext dbContext)
        {
            _productService = new ProductService(dbContext);
        }

        public async Task<IActionResult> Index()
        {
            return View(await _productService.GetAllViewModel());
        }

        public IActionResult Create()
        {
            return View("SaveProduct", new SaveProductViewModel());
        }

        public async Task<IActionResult> Edit(int id)
        {
            return View("SaveProduct", await _productService.GetByIdSaveViewModel(id));
        }

        [HttpPost]
        public async Task<IActionResult> Create(SaveProductViewModel vm)
        {
            if (ModelState.IsValid)
            {
                return View("SaveProduct", vm);
            }

            await _productService.Add(vm);
            return RedirectToRoute(new { controller = "Product", action = "Index" });
        }

        [HttpPost]
        public async Task<IActionResult> Edit(SaveProductViewModel vm)
        {
            if (ModelState.IsValid)
            {
                return View("SaveProduct", vm);
            }
            await _productService.Update(vm);
            return RedirectToRoute(new { controller = "Product", action = "Index" });
        }


    }
}

