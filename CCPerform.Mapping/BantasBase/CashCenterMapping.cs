using CCPerform.Entity.BantasBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCPerform.Mapping.BantasBase
{
    public class CashCenterMapping : IEntityTypeConfiguration<CashCenter>
    {
        public void Configure(EntityTypeBuilder<CashCenter> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.CashCenterCode).IsRequired();
            builder.Property(x => x.CashCenterName).IsRequired();
            builder.HasOne(x => x.CashCenterGroup).WithMany(x => x.CashCenters).HasForeignKey(x => x.CashCenterGroupID);
            builder.HasOne(x => x.OperationDepartment).WithMany(x => x.CashCenters).HasForeignKey(x => x.OperationDepartmentID);
            builder.HasOne(x => x.SecurityDepartment).WithMany(x => x.CashCenters).HasForeignKey(x => x.SecurityDepartmentID);
        }
    }
}
