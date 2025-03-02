using Salvador.Domain.Entities;

namespace Salvador.Interface.Services
{
    public interface IRecordService
    {
        IEnumerable<Record> GetRecord();
        Task<Record> AddToRecord();
    }
}
