using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Salvador.UI.Entities.Base.Interface;

namespace Salvador.UI.Entities.Base
{
    public abstract class BaseEntity : IBaseEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
    }
}
