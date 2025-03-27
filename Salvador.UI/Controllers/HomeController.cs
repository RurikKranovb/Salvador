using Microsoft.AspNetCore.Mvc;
using Salvador.UI.Extension;
using Salvador.UI.Infrastructure.Interface;
using Salvador.UI.Infrastructure.Mapping;
using Salvador.UI.ViewModel;

namespace Salvador.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRecordData _recordData;
        public HomeController(IRecordData recordData)
        {
            _recordData = recordData;
        }

        public IActionResult Index()
        {

            var item = _recordData.GetAll().Select(e => e.ToView());
            return View(item);
        }

        public void Record(RecordViewModel time)
        {

        
            var t = 100;
        }
    }
}
