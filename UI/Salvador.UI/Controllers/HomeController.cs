using Microsoft.AspNetCore.Mvc;
using Salvador.Domain.Models;
using Salvador.Interface.Services;

namespace Salvador.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRecordService _service;
        private IEnumerable<RecordModel> _recordModel;

        public HomeController(IRecordService service)
        {
            _recordModel = new List<RecordModel>();
            _service = service;
        }
        public IActionResult Index()
        {
            _recordModel = _service.GetRecord()
                .Select(record => new RecordModel()
                {
                    Phone = record.Phone,
                    DateTime = record.DateTime,
                    Email = record.Email,
                    Name = record.Name
                });


            return View(_recordModel);
        }
    }
}
