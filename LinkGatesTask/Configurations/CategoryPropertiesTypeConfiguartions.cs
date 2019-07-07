using LinkGatesTask.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace LinkGatesTask.Configurations
{
    public class CategoryPropertiesTypeConfiguartions : EntityTypeConfiguration<CategoryProperties>
    {
        public CategoryPropertiesTypeConfiguartions()
        {
            HasKey(a =>new { a.Cati_Id ,a.Prop_Id});
            ToTable("CategoryPropertiesr");

            HasRequired<Property>(a => a.Property)
                .WithMany(a => a.CategoryProperties)
                .HasForeignKey(a => a.Prop_Id);

            HasRequired<Category>(a => a.Category)
                .WithMany(a => a.CategoryProperties)
                .HasForeignKey(a => a.Cati_Id);
        }
    }
}