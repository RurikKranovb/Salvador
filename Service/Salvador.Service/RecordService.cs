using Microsoft.EntityFrameworkCore;
using Salvador.DAL.Context;
using Salvador.Domain.Entities;
using Salvador.Interface.Services;

namespace Salvador.Service
{
    public class RecordService : IRecordService
    {
        private readonly DataBase _db;

        public RecordService(DataBase db)
        {
            _db = db;
        }

        public IEnumerable<Record> GetRecord() => _db.Records.AsEnumerable();

        public async Task<Record> AddToRecord()
        {
            await using var transaction = await _db.Database.BeginTransactionAsync();

            var record = new Record()
            {

            };

            return record;
        }
    }
}
