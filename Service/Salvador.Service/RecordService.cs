using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Salvador.DAL.Context;
using Salvador.Domain.Entities;
using Salvador.Domain.Models;
using Salvador.Interface.Services;

namespace Salvador.Service
{
    public class RecordService : IRecordService
    {
        private readonly DataBase _db;
        private readonly ILogger _logger;

        public RecordService(DataBase db, ILogger<RecordService> logger)
        {
            _db = db;
            _logger = logger;
        }

        public IEnumerable<Record> GetRecord() => _db.Records.AsEnumerable();

        public async Task<bool> AddToRecord(RecordModel recordModel)
        {
            try
            {
                await using var transaction = await _db.Database.BeginTransactionAsync();

                _db.Records.Add(new Record()
                {
                    Phone = recordModel.Phone,
                    DateTime = recordModel.DateTime,
                    Email = recordModel.Email,
                    Name = recordModel.Name
                });

                await _db.SaveChangesAsync().ConfigureAwait(false);

                await transaction.CommitAsync().ConfigureAwait(false);

                return true;
            }
            catch (Exception e)
            {
                _logger.LogInformation(e.Message,e);
                return false;
            }
        }
    }
}
