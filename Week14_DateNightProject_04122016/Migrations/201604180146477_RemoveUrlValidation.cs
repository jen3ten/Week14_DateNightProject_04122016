namespace Week14_DateNightProject_04122016.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveUrlValidation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.DateNightModels", "Zip", c => c.String(maxLength: 5));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.DateNightModels", "Zip", c => c.String());
        }
    }
}
