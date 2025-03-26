using Microsoft.EntityFrameworkCore;
using Salvador.DAL.Context;

namespace Salvador.UI.Initialize
{
    public class SalvadorDbInitializer
    {
        private readonly SalvadorDataBase _db;

        public SalvadorDbInitializer(SalvadorDataBase db) => _db = db;

        public void Initialize() => InitializeAsync().Wait();

        private async Task InitializeAsync()
        {
            var db = _db.Database;

            await db.MigrateAsync().ConfigureAwait(false);

            if (await _db.Records.AnyAsync())
                return;

            using (var transaction = await db.BeginTransactionAsync().ConfigureAwait(false))
            {
                await _db.RecordItems.AddRangeAsync(TestData.Items).ConfigureAwait(false);
                await _db.SaveChangesAsync().ConfigureAwait(false);

                await transaction.CommitAsync().ConfigureAwait(false);
            }

            using (var transaction = await db.BeginTransactionAsync().ConfigureAwait(false))
            {
                await _db.Records.AddRangeAsync(TestData.RecordItemsList).ConfigureAwait(false);
                await _db.SaveChangesAsync().ConfigureAwait(false);

                await transaction.CommitAsync().ConfigureAwait(false);

            }
        }
    }
}
