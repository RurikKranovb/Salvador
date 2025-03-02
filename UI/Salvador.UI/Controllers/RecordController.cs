using Microsoft.AspNetCore.Mvc;
using Salvador.Domain.Entities;
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

        //public IEnumerable<Record> GetRecord()
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<Record> AddToRecord()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
