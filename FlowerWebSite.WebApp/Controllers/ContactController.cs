using FlowerWebSite.WebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FlowerWebSite.WebApp.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public void Save(ContactViewModel viewModel)
        {

        }
    }
}
