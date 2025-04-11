using Application.Services;
using Database;
using Microsoft.AspNetCore.Mvc;

namespace StockApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductService _productService;

        public HomeController(ApplicationContext dbContext)
        {
            _productService = new ProductService(dbContext);
        }

        public async Task<IActionResult> Index()
        {
            return View(await _productService.GetAllViewModel());
        }

    }
}
