using CCPerform.Core.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCPerform.Entity.BantasBase
{
    public class OperationDepartment: BaseEntity
    {
        //Operasyon Biriminin Sinifi
        public string OperationDepartmentName { get; set; }

        public virtual List<CashCenter> CashCenters { get; set; }
    }
}
