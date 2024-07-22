using CCPerform.Core.Abstract;
using CCPerform.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCPerform.Core.Concrete
{
    public class BaseEntity : IBaseEntity<Guid>, IEntity
    {
        public Guid ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public Status Status { get; set; }
    }
}
