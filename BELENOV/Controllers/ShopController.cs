using Microsoft.AspNetCore.Mvc;
using BELENOV.Data;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BELENOV.Controllers
{
    public class ShopController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ShopController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var products = await _context.Products.ToListAsync();
            return View(products);
        }

        // Метод для отображения подробностей о товаре по его ID
        public async Task<IActionResult> ProductDetails(int productId)
        {
            var product = await _context.Products.FindAsync(productId);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }
    }
}
