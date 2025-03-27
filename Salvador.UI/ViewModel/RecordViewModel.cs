using Salvador.Domain.Entities.Base.Interface;
using Salvador.UI.Model;

namespace Salvador.UI.ViewModel
{
    public class RecordViewModel: IDefaultEntity
    {
        public int Id { get; set; }
        public RecordViewModel()
        {
            Items = new List<RecordItemViewModel>();
        }
        public string Name { get; set; }
        public string Phone { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Price { get; set; }
        public List<RecordItemViewModel> Items { get; set; }
    }
}
