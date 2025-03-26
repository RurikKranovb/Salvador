using System.ComponentModel.DataAnnotations;
using Salvador.UI.Entities.Base.Interface;

namespace Salvador.UI.Entities.Base
{
    public abstract class DefaultEntity : BaseEntity, IDefaultEntity
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Phone { get; set; }
    }
}
