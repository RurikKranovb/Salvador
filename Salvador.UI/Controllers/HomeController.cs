using Microsoft.AspNetCore.Mvc;
using Salvador.UI.Extension;
using Salvador.UI.ViewModel;

namespace Salvador.UI.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
            RecordViewModel model = new RecordViewModel();
        }
        public IActionResult Index()
        {
            RecordViewModel model = new RecordViewModel();

            return View(model);
        }

        public void Record(RecordViewModel time)
        {

        
            var t = 100;
        }
    }
}
