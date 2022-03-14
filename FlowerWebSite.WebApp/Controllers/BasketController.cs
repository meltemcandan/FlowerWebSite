using Microsoft.AspNetCore.Mvc;

namespace FlowerWebSite.WebApp.Controllers
{
    public class BasketController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
       
    }
}
