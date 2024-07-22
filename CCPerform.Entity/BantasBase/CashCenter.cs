using CCPerform.Core.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCPerform.Entity.BantasBase
{
    public class CashCenter: BaseEntity
    {
        bool _isCashAssigned;
        short _cashCenterCode;
        public short CashCenterCode
        {
            get
            {
                return _cashCenterCode;
            }
            set
            {
                _cashCenterCode = value;
                _isCashAssigned = true;
            }
        }

        public string CCNo
        {
            get
            {
                if (!_isCashAssigned) throw new Exception("CashCenterCode atanmamıs lütfen önce onu veriniz");
                return $"CC{_cashCenterCode}";
            }

        }

        public string CashCenterName { get; set; }

        public Guid CashCenterGroupID { get; set; }
        public Guid OperationDepartmentID { get; set; }
        public Guid SecurityDepartmentID { get; set; }


        public virtual CashCenterGroup CashCenterGroup { get; set; }
        public virtual OperationDepartment OperationDepartment { get; set; }
        public virtual SecurityDepartment SecurityDepartment { get; set; }
    }
}
