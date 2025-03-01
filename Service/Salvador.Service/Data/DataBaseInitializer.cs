using Microsoft.EntityFrameworkCore;
using Salvador.DAL.Context;

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
        }
    }
}
