namespace Week14_DateNightProject_04122016.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMultipleValidations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.DateNightModels", "Title", c => c.String(nullable: false, maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.DateNightModels", "Title", c => c.String(maxLength: 30));
        }
    }
}
