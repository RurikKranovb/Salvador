using Microsoft.AspNetCore.Mvc;

namespace Salvador.UI.Controllers
{
    public class RecordController : Controller
    {
        public IActionResult Record()
        {
            return View();
        }

        public IActionResult GetRecord()
        {
            return View();
        }
    }
}
