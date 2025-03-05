using Microsoft.EntityFrameworkCore;
using Salvador.Domain.Entities;

namespace Salvador.DAL.Context
{
    public class DataBase : DbContext
    {
        public DbSet<Record> Records => Set<Record>();

        public DataBase(DbContextOptions<DataBase> options) : base(options) { }
    }
}
