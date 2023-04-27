namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class categyadd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "CreatedAt", c => c.DateTime(nullable: false));
            AddColumn("dbo.Categories", "CreatedBy", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Categories", "CreatedBy");
            DropColumn("dbo.Categories", "CreatedAt");
        }
    }
}
