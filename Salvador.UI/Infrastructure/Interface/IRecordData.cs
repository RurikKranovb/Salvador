using Salvador.UI.Model;

namespace Salvador.UI.Infrastructure.Interface
{
    public interface IRecordData
    {
        IEnumerable<RecordItems> GetAll();

        void Add(RecordItems record);

        void SaveChanges();
    }
}
