using Salvador.Domain.Entities.Base.Interface;
using Salvador.UI.Model;

namespace Salvador.UI.ViewModel
{
    public class RecordItemViewModel: IDefaultEntity
    {
        public int Id { get; set; }
        public RecordItemViewModel()
        {
            Items = new List<RecordViewModel>();
        }
        public string Name { get; set; }
        public string Phone { get; set; }
        public DateTime TimeRecord { get; set; }
        public List<RecordViewModel> Items { get; set; }
    }
}
