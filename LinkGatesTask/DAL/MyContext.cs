namespace LinkGatesTask.DAL
{
    using LinkGatesTask.Configurations;
    using LinkGatesTask.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class MyContext : DbContext
    {

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PropertyTypeConfiguartions());
            modelBuilder.Configurations.Add(new CategoryTypeConfiguartions());
            modelBuilder.Configurations.Add(new DeviceTypeConfiguartions());
            modelBuilder.Configurations.Add(new CategoryPropertiesTypeConfiguartions());
            modelBuilder.Configurations.Add(new PropertyValueTypeConfiguartions());
        }
        public MyContext()
            : base("name=LinkGatesDB")
        {
        }

        public DbSet<Property> Properties { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<CategoryProperties> CategoryProperties { get; set; }
        public DbSet<PropertyValue> PropertyValues { get; set; }

    }

}