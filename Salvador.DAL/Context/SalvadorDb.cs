using Microsoft.EntityFrameworkCore;
using Salvador.Domain.Entities;

namespace Salvador.DAL.Context
{
    public class SalvadorDb : DbContext
    {
        public DbSet<Record> Records => Set<Record>();
    }
}
