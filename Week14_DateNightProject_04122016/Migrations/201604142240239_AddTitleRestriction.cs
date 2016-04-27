namespace Week14_DateNightProject_04122016.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTitleRestriction : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.DateNightModels", "Title", c => c.String(maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.DateNightModels", "Title", c => c.String());
        }
    }
}
