using LinkGatesTask.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace LinkGatesTask.Configurations
{
    public class DeviceTypeConfiguartions:EntityTypeConfiguration<Device>
    {
        public DeviceTypeConfiguartions()
        {
            HasKey(a => a.Dev_Id);
            ToTable("Devices");
            Property(a => a.Dev_Name).IsRequired();
            Property(a => a.SerialNumber).IsRequired();
            Property(a => a.Acquisition_Date).HasColumnName("Date").IsRequired();

            HasRequired<Category>(a => a.Category)
                .WithMany(a => a.Devices)
                .HasForeignKey(a => a.Cati_Id);
        }
    }
}