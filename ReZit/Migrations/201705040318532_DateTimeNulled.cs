namespace ReZit.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DateTimeNulled : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Posts", "PostedAt", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Posts", "PostedAt", c => c.DateTime(nullable: false));
        }
    }
}
