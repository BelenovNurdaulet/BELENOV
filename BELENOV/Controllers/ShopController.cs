using Microsoft.AspNetCore.Mvc;

namespace BELENOV.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
