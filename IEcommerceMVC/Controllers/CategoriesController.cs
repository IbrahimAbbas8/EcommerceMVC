using IEcommerceMVC.Data.DataBaseContexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IEcommerceMVC.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly EcommerceDbContext context;
        [ViewData]
        public string x { get; set; } = "Index";
        public CategoriesController(EcommerceDbContext context)
        {
            this.context = context;
        }
        public async Task<IActionResult> Index()
        {
            var categories = await context.Categories.ToListAsync();
            return View(categories);
        }
    }
}
