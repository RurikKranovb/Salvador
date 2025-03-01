using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Salvador.Domain.Entities.Base;

namespace Salvador.Domain.Entities
{
    public class Record : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime DateTime { get; set; }
        public TimeSpan Time { get; set; } 
    }
}
