using Microsoft.AspNetCore.Mvc;
using Salvador.Interface.Services;

namespace Salvador.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRecordService _service;

        public HomeController(IRecordService service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            _service.GetRecord();
            return View();
        }
    }
}
