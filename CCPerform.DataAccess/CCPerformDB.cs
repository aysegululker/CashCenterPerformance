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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=CCPerformdb;uid=sa;pwd=123");
            base.OnConfiguring(optionsBuilder);
        }

        //57.video  kalındı

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
