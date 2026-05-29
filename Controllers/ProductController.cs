using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BTT6.Data;

namespace BTT6.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int? categoryId)
        {
            var categories = await _context.Categories.ToListAsync();
            ViewBag.Categories = categories;
            ViewBag.SelectedCategoryId = categoryId;

            var products = _context.Products.Include(p => p.Category).AsQueryable();

            if (categoryId.HasValue)
            {
                products = products.Where(p => p.CategoryId == categoryId.Value);
            }

            return View(await products.ToListAsync());
        }

        public async Task<IActionResult> Details(int id)
        {
            var product = await _context.Products
                .Include(p => p.Category)
                .FirstOrDefaultAsync(p => p.ProductId == id);

            if (product == null)
                return NotFound();

            return View(product);
        }
    }
}
