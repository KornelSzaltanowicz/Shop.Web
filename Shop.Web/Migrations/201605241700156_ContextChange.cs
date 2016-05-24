namespace Shop.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ContextChange : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "Opportunity", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "Opportunity");
        }
    }
}
