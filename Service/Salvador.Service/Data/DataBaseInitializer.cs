using Microsoft.EntityFrameworkCore;
using Salvador.DAL.Context;
using Salvador.Domain.Entities;

namespace Salvador.Service.Data
{
   public class DataBaseInitializer
    {
        private readonly DataBase _dataBase;

        public DataBaseInitializer(DataBase dataBase)
        {
            _dataBase = dataBase;
        }

        public void Initializer() => InitializeAsync().Wait();

        private async Task InitializeAsync()
        {
            var db = _dataBase.Database;

            await db.MigrateAsync().ConfigureAwait(false);


            await InitializerTestDataAsync().ConfigureAwait(false);
        }

        private async Task InitializerTestDataAsync()
        {
            var db = _dataBase.Database;

            await using var transaction = await db.BeginTransactionAsync().ConfigureAwait(false);

            await _dataBase.Records.AddRangeAsync(TestData.Records).ConfigureAwait(false);

            await db.ExecuteSqlRawAsync("SET IDENTITY_INSERT [dbo].[Records] ON");

            await _dataBase.SaveChangesAsync().ConfigureAwait(false);

            await db.ExecuteSqlRawAsync("SET IDENTITY_INSERT [dbo].[Records] OFF");

            await transaction.CommitAsync().ConfigureAwait(false);

        }
    }

   public class TestData
   {
       public static IEnumerable<Record> Records { get; } = new[]
       {
           new Record()
           {
               Id = 1,
               Phone = "89992583378",
               DateTime = DateTime.Now,
               Email = "yandex@mail.ru",
               Name = "Nastoyka",
           },
           new Record()
           {
               Id = 2,
               Phone = "88888888888",
               DateTime = DateTime.Now,
               Email = "google@mail.ru",
               Name = "bygylma",
           },
           new Record()
           {
               Id = 3,
               Phone = "87777777777",
               DateTime = DateTime.Now,
               Email = "mail@mail.ru",
               Name = "wiski",
           }
       };
   }
}
