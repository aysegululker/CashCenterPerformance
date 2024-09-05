using CCPerform.Entity.BantasBase;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCPerform.DataAccess
{
    public class CCPerformDB: DbContext
    {
        public CCPerformDB(DbContextOptions<CCPerformDB> option) : base(option)
        {

        }


        //54.video 01.25 kalındı


        #region BantasDbSetArea

        #region BantasBase
        public DbSet<CashCenter> CashCenters { get; set; }
        public DbSet<CashCenterGroup> CashCenterGroups { get; set; }
        public DbSet<OperationDepartment> OperationDepartments { get; set; }
        public DbSet<SecurityDepartment> SecurityDepartments { get; set; }
        #endregion


        #endregion

    }
}
