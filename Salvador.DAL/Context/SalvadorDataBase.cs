using Microsoft.EntityFrameworkCore;
using Salvador.Domain.Entities;

namespace Salvador.DAL.Context
{
    public class SalvadorDataBase : DbContext
    {
        public DbSet<Record> Records => Set<Record>();

        public DbSet<RecordItem> RecordItems => Set<RecordItem>();

        public SalvadorDataBase(DbContextOptions<SalvadorDataBase> options) : base(options)
        {
            
        }
    }
}
