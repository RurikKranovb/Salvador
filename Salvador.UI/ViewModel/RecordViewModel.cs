using Salvador.Domain.Entities.Base;
using Salvador.Domain.Entities.Base.Interface;

namespace Salvador.UI.ViewModel
{
    public class RecordViewModel : IDefaultEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime EndDate { get; set; } = DateTime.Now;
    }
}
