namespace Shop.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModelChanges : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DataCarriers",
                c => new
                    {
                        DataCarrierId = c.Int(nullable: false, identity: true),
                        Type = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DataCarrierId);
            
            CreateTable(
                "dbo.PublicationDates",
                c => new
                    {
                        PublicationDateId = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PublicationDateId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PublicationDates");
            DropTable("dbo.DataCarriers");
        }
    }
}
