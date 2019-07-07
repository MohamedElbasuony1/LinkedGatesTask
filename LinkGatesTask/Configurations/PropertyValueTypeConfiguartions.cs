using LinkGatesTask.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace LinkGatesTask.Configurations
{
    public class PropertyValueTypeConfiguartions:EntityTypeConfiguration<PropertyValue>
    {
        public PropertyValueTypeConfiguartions()
        {
            HasKey(a => a.Val_Id);
            ToTable("PropertValues");

            HasRequired<Property>(a=>a.Property)
                .WithMany()
                .HasForeignKey(a => a.Prop_Id);

            HasRequired<Device>(a => a.Device)
                .WithMany(a => a.PropertyValues).
                HasForeignKey(a => a.Dev_Id);
        }
    }
}