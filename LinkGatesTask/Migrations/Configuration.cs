namespace LinkGatesTask.Migrations
{
    using LinkGatesTask.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LinkGatesTask.DAL.MyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LinkGatesTask.DAL.MyContext context)
        {
            context.Properties.AddOrUpdate(a => a.Prop_Id,
                new Property() { Prop_Id = 1, Description = "IP" },
                new Property() { Prop_Id = 2, Description = "IsColor" },
                new Property() { Prop_Id = 3, Description = "Brand" },
                new Property() { Prop_Id = 4, Description = "Processor" },
                new Property() { Prop_Id = 5, Description = "HD" },
                new Property() { Prop_Id = 6, Description = "Ram" },
                new Property() { Prop_Id = 7, Description = "Display" },
                new Property() { Prop_Id = 8, Description = "Current User" },
                new Property() { Prop_Id = 9, Description = "Ports" },
                new Property() { Prop_Id = 10, Description = "Speed" },
                new Property() { Prop_Id = 11, Description = "X" },
                new Property() { Prop_Id = 12, Description = "Y" }
                );

            context.Categories.AddOrUpdate(a => a.Cati_Id,
                new Category() { Cati_Id = 1, Cati_Name = "Printer" },
                new Category() { Cati_Id = 2, Cati_Name = "Labtop" },
                new Category() { Cati_Id = 3, Cati_Name = "Switch" }
                );

            context.CategoryProperties.AddOrUpdate(
                new CategoryProperties() { Cati_Id = 1, Prop_Id = 1 },
                new CategoryProperties() { Cati_Id = 1, Prop_Id = 2 },
                new CategoryProperties() { Cati_Id = 1, Prop_Id = 3 },
                new CategoryProperties() { Cati_Id = 2, Prop_Id = 4 },
                new CategoryProperties() { Cati_Id = 2, Prop_Id = 5 },
                new CategoryProperties() { Cati_Id = 2, Prop_Id = 6 },
                new CategoryProperties() { Cati_Id = 2, Prop_Id = 7 },
                new CategoryProperties() { Cati_Id = 2, Prop_Id = 1 },
                new CategoryProperties() { Cati_Id = 2, Prop_Id = 3 },
                new CategoryProperties() { Cati_Id = 2, Prop_Id = 8 },
                new CategoryProperties() { Cati_Id = 3, Prop_Id = 9 },
                new CategoryProperties() { Cati_Id = 3, Prop_Id = 10 },
                new CategoryProperties() { Cati_Id = 3, Prop_Id = 1 },
                new CategoryProperties() { Cati_Id = 3, Prop_Id = 3 },
                new CategoryProperties() { Cati_Id = 3, Prop_Id = 11 },
                new CategoryProperties() { Cati_Id = 3, Prop_Id = 12 }
                );
        }
    }
}
