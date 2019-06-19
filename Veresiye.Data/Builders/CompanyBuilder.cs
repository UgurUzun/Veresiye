using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veresiye.Model;

namespace Veresiye.Data.Builders
{
    public class CompanyBuilder
    {
        public CompanyBuilder (EntityTypeConfiguration<Company>builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Name).IsRequired().HasMaxLength(100);
            builder.Property(a => a.Phone).IsRequired().HasMaxLength(20);
            builder.Property(a => a.Region).HasMaxLength(100);
            builder.Property(a => a.City).HasMaxLength(100);
        }
    }
}
