namespace Shop.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SomeModelChanges : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "Type_BookTypeId", c => c.Int());
            AddColumn("dbo.BookTypes", "Value", c => c.Int(nullable: false));
            CreateIndex("dbo.Books", "Type_BookTypeId");
            AddForeignKey("dbo.Books", "Type_BookTypeId", "dbo.BookTypes", "BookTypeId");
            DropColumn("dbo.Books", "Type");
            DropColumn("dbo.BookTypes", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BookTypes", "Name", c => c.String());
            AddColumn("dbo.Books", "Type", c => c.Int(nullable: false));
            DropForeignKey("dbo.Books", "Type_BookTypeId", "dbo.BookTypes");
            DropIndex("dbo.Books", new[] { "Type_BookTypeId" });
            DropColumn("dbo.BookTypes", "Value");
            DropColumn("dbo.Books", "Type_BookTypeId");
        }
    }
}
