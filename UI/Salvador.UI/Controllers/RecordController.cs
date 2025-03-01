using Microsoft.AspNetCore.Mvc;
using Salvador.Interface.Services;

namespace Salvador.UI.Controllers
{
    public class RecordController : ControllerBase, IRecordService
    {
        private readonly IRecordService _recordService;


        public RecordController(IRecordService recordService)
        {
            _recordService = recordService;
        }
        //public IActionResult Record()
        //{
        //    return View();
        //}

        public void AddToRecord()
        {
            _recordService.AddToRecord();
        }
    }
}
