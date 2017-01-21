namespace LogInApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RegestermodelChange1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "PhoneNum", c => c.String(nullable: false));
            AddColumn("dbo.AspNetUsers", "IsActive", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "IsActive");
            DropColumn("dbo.AspNetUsers", "PhoneNum");
        }
    }
}
