using Microsoft.AspNetCore.Mvc;

namespace FlowerWebSite.WebApp.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Papatya()
        {
            return View();
        }

        public IActionResult KirmiziGul()
        {
            return View();
        }
        public IActionResult YildizCicegi()
        {
            return View();
        }
        public IActionResult SariLale()
        {
            return View();
        }
    }
}
