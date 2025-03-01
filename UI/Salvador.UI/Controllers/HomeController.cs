using Microsoft.AspNetCore.Mvc;

namespace Salvador.UI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
