using Microsoft.AspNetCore.Mvc;

namespace BELENOV.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
