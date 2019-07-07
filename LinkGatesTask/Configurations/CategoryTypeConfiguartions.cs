using LinkGatesTask.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace LinkGatesTask.Configurations
{
    public class CategoryTypeConfiguartions:EntityTypeConfiguration<Category>
    {
        public CategoryTypeConfiguartions()
        {
            HasKey(a => a.Cati_Id);
            ToTable("Categories");
            Property(a => a.Cati_Name).IsRequired();
        }
    }
}