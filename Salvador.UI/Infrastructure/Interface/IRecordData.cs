using Salvador.Domain.Entities;
using Salvador.UI.Model;

namespace Salvador.UI.Infrastructure.Interface
{
    public interface IRecordData
    {
        IEnumerable<Record> GetAll();

        void Add(Record recordModel);

        void SaveChanges();
    }
}
