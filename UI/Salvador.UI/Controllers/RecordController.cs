using Microsoft.AspNetCore.Mvc;
using Salvador.Domain.Entities;
using Salvador.Domain.Models;
using Salvador.Interface.Services;

namespace Salvador.UI.Controllers
{
    public class RecordController : ControllerBase/*, IRecordService*/
    {
        private readonly IRecordService _recordService;


        public RecordController(IRecordService recordService)
        {
            _recordService = recordService;
        }

        public IActionResult Record(RecordModel model)
        {
            _recordService.AddToRecord(model);
            return RedirectToAction(Url.Action("Index", "Home"));
        }
    }
}
