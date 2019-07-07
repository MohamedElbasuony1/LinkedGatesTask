namespace LinkGatesTask.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Cati_Id = c.Int(nullable: false, identity: true),
                        Cati_Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Cati_Id);
            
            CreateTable(
                "dbo.CategoryPropertiesr",
                c => new
                    {
                        Cati_Id = c.Int(nullable: false),
                        Prop_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Cati_Id, t.Prop_Id })
                .ForeignKey("dbo.Categories", t => t.Cati_Id, cascadeDelete: true)
                .ForeignKey("dbo.Properties", t => t.Prop_Id, cascadeDelete: true)
                .Index(t => t.Cati_Id)
                .Index(t => t.Prop_Id);
            
            CreateTable(
                "dbo.Properties",
                c => new
                    {
                        Prop_Id = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Prop_Id);
            
            CreateTable(
                "dbo.Devices",
                c => new
                    {
                        Dev_Id = c.Int(nullable: false, identity: true),
                        Dev_Name = c.String(nullable: false),
                        SerialNumber = c.String(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Memo = c.String(),
                        Cati_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Dev_Id)
                .ForeignKey("dbo.Categories", t => t.Cati_Id, cascadeDelete: true)
                .Index(t => t.Cati_Id);
            
            CreateTable(
                "dbo.PropertValues",
                c => new
                    {
                        Val_Id = c.Int(nullable: false, identity: true),
                        Prop_Id = c.Int(nullable: false),
                        Dev_Id = c.Int(nullable: false),
                        Value = c.String(),
                    })
                .PrimaryKey(t => t.Val_Id)
                .ForeignKey("dbo.Devices", t => t.Dev_Id, cascadeDelete: true)
                .ForeignKey("dbo.Properties", t => t.Prop_Id, cascadeDelete: true)
                .Index(t => t.Prop_Id)
                .Index(t => t.Dev_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PropertValues", "Prop_Id", "dbo.Properties");
            DropForeignKey("dbo.PropertValues", "Dev_Id", "dbo.Devices");
            DropForeignKey("dbo.Devices", "Cati_Id", "dbo.Categories");
            DropForeignKey("dbo.CategoryPropertiesr", "Prop_Id", "dbo.Properties");
            DropForeignKey("dbo.CategoryPropertiesr", "Cati_Id", "dbo.Categories");
            DropIndex("dbo.PropertValues", new[] { "Dev_Id" });
            DropIndex("dbo.PropertValues", new[] { "Prop_Id" });
            DropIndex("dbo.Devices", new[] { "Cati_Id" });
            DropIndex("dbo.CategoryPropertiesr", new[] { "Prop_Id" });
            DropIndex("dbo.CategoryPropertiesr", new[] { "Cati_Id" });
            DropTable("dbo.PropertValues");
            DropTable("dbo.Devices");
            DropTable("dbo.Properties");
            DropTable("dbo.CategoryPropertiesr");
            DropTable("dbo.Categories");
        }
    }
}
