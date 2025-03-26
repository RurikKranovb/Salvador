using System.ComponentModel.DataAnnotations.Schema;
using Salvador.Domain.Entities.Base;

namespace Salvador.Domain.Entities
{
    public class Record : DefaultEntity
    {
        public string Phone { get; set; }
        public DateTime TimeRecord { get; set; }

        public int? RecordItemId { get; set; }

        [ForeignKey(nameof(RecordItemId))]
        public virtual RecordItem Items { get; set; }
    }
}
