using Microsoft.AspNetCore.Mvc;

namespace BELENOV.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
