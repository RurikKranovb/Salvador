using Salvador.Domain.Entities;
using Salvador.UI.Infrastructure.Interface;
using Salvador.UI.Initialize;
using Salvador.UI.Model;

namespace Salvador.UI.Infrastructure.Service
{
    public class SqlRecordDate : IRecordData
    {

        private readonly List<Record> _recordItemsList = TestData.RecordItemsList;
        public IEnumerable<Record> GetAll() => _recordItemsList;

        public void Add(Record recordModel)
        {
            if (recordModel is null)
                throw new ArgumentNullException(nameof(recordModel));

            if (_recordItemsList.Contains(recordModel))
                return;

            recordModel.Id = _recordItemsList.Count == 0 ? 1 : _recordItemsList.Max(e => e.Id) + 1;

            var endDate = _recordItemsList.Select(item => item.Items.Select(recordItem => recordItem.WorkTime));
            _recordItemsList.Add(recordModel);

        }

        public void SaveChanges()
        {
            
        }
    }
}
