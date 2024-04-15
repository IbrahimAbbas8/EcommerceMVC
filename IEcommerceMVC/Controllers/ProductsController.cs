using IEcommerceMVC.Data.DataBaseContexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IEcommerceMVC.Controllers
{
    public class ProductsController : Controller
    {
        private readonly EcommerceDbContext context;

        public ProductsController(EcommerceDbContext context)
        {
            this.context = context;
        }
        public async Task<IActionResult> Index()
        {
            var products = await context.Products.Include(c => c.Category).OrderBy(p => p.Price).ToListAsync();
            return View(products);
        }
    }
}
