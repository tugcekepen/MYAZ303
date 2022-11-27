using Microsoft.AspNetCore.Mvc;

namespace MVCProjem.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
