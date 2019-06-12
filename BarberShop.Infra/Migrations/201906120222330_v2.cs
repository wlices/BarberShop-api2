namespace BarberShop.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Schedulings", "Id", "dbo.Customers");
            DropForeignKey("dbo.Schedulings", "Id", "dbo.Services");
            DropIndex("dbo.Schedulings", new[] { "Id" });
            DropPrimaryKey("dbo.Schedulings");
            AddColumn("dbo.Schedulings", "Customer_Id", c => c.Int(nullable: false));
            AddColumn("dbo.Schedulings", "Service_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Schedulings", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Schedulings", "Id");
            CreateIndex("dbo.Schedulings", "Customer_Id");
            CreateIndex("dbo.Schedulings", "Service_Id");
            AddForeignKey("dbo.Schedulings", "Customer_Id", "dbo.Customers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Schedulings", "Service_Id", "dbo.Services", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Schedulings", "Service_Id", "dbo.Services");
            DropForeignKey("dbo.Schedulings", "Customer_Id", "dbo.Customers");
            DropIndex("dbo.Schedulings", new[] { "Service_Id" });
            DropIndex("dbo.Schedulings", new[] { "Customer_Id" });
            DropPrimaryKey("dbo.Schedulings");
            AlterColumn("dbo.Schedulings", "Id", c => c.Int(nullable: false));
            DropColumn("dbo.Schedulings", "Service_Id");
            DropColumn("dbo.Schedulings", "Customer_Id");
            AddPrimaryKey("dbo.Schedulings", "Id");
            CreateIndex("dbo.Schedulings", "Id");
            AddForeignKey("dbo.Schedulings", "Id", "dbo.Services", "Id");
            AddForeignKey("dbo.Schedulings", "Id", "dbo.Customers", "Id");
        }
    }
}
