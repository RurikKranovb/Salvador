using Salvador.Domain.Entities.Base;

namespace Salvador.Domain.Entities
{
    public class RecordItem : DefaultEntity
    {
        public decimal Price { get; set; }
        public TimeSpan Date { get; set; }

        public virtual ICollection<Record> Records { get; set; }
    }
}
