using LinkGatesTask.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace LinkGatesTask.Configurations
{
    public class PropertyTypeConfiguartions:EntityTypeConfiguration<Property>
    {
        public PropertyTypeConfiguartions()
        {
            HasKey(a => a.Prop_Id);
            ToTable("Properties");
            Property(a => a.Description).IsRequired();
        }
    }
}