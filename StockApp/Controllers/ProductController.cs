using Application.Services;
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

        public IActionResult Index()
        {
            return View();
        }
    }
}
