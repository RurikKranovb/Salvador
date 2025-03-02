using Salvador.Domain.Entities;
using Salvador.Domain.Models;

namespace Salvador.Interface.Services
{
    public interface IRecordService
    {
        IEnumerable<Record> GetRecord();
        Task<bool> AddToRecord(RecordModel recordModel);
    }
}
