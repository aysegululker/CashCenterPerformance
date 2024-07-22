using CCPerform.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCPerform.Core.Abstract
{
    public interface IEntity
    {
        //Created Part
        DateTime CreatedDate { get; set; }
        string CreatedBy { get; set; }


        //Modified Part
        DateTime ModifiedDate { get; set; }
        string ModifiedBy { get; set; }

        //Status
        Status Status { get; set; }
    }
}
