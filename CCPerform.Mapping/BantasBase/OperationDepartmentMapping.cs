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
    public class OperationDepartmentMapping : IEntityTypeConfiguration<OperationDepartment>
    {
        public void Configure(EntityTypeBuilder<OperationDepartment> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.OperationDepartmentName).IsRequired();
        }
    }
}
