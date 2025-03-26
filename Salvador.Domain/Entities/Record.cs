using System.ComponentModel.DataAnnotations.Schema;
using Salvador.Domain.Entities.Base;

namespace Salvador.Domain.Entities
{
    public class Record : DefaultEntity
    {
        public string Phone { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int? RecordItemId { get; set; }

        public decimal Price { get; set; }

        [ForeignKey(nameof(RecordItemId))]
        public virtual ICollection<RecordItem> Items { get; set; }
    }
}
