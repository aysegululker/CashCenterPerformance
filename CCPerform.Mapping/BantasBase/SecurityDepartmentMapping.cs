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
    public class SecurityDepartmentMapping : IEntityTypeConfiguration<SecurityDepartment>
    {
        public void Configure(EntityTypeBuilder<SecurityDepartment> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.SecurityDepartmentName).IsRequired();
        }
    }
}
