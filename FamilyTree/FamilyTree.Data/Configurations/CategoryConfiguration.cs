using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FamilyTree.Core.Entities;

namespace FamilyTree.Data.Configurations
{
    public class CategoryConfiguration : EntityTypeConfiguration<Category>
    {
        public CategoryConfiguration()
        {
            Property(c => c.Name).IsRequired().HasMaxLength(250);
            Property(c => c.Active).IsRequired();
            Property(c => c.IsDeleted).IsRequired();
        }
    }
}
