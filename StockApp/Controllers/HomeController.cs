using Microsoft.AspNetCore.Mvc;
using StockApp.Core.Application.Interfaces.Services;

namespace StockApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService _productService;

        public HomeController(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _productService.GetAllViewModel());
        }

    }
}
