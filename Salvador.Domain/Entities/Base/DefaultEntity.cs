using System.ComponentModel.DataAnnotations;
using Salvador.Domain.Entities.Base.Interface;

namespace Salvador.Domain.Entities.Base
{
    public abstract class DefaultEntity : BaseEntity, IDefaultEntity
    {
        [Required]
        public string Name { get; set; }
    }
}
