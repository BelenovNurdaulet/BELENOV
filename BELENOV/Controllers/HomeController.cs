using BELENOV.Models;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System.Diagnostics;

namespace GameShop.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult SetLanguage(string culture, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
            );

            return LocalRedirect(returnUrl);
        }


        private readonly IStringLocalizer _localizer;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IStringLocalizer<HomeController> localizer)
        {
            _logger = logger;
            _localizer = localizer;
        }

        public IActionResult Index()
        {
            ViewData["Home"] = _localizer["Home"];
            return View();
        }

        public IActionResult About()
        {
            
            return View();
        }

        public IActionResult Shop()
        {

            return View();
        }

        public IActionResult Contact()
        {

            return View();
        }

      

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
