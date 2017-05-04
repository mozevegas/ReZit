namespace ReZit.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeExplicitThing : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Posts", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.Posts", new[] { "UserId" });
            AlterColumn("dbo.Posts", "UserId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Posts", "UserId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Posts", "UserId");
            AddForeignKey("dbo.Posts", "UserId", "dbo.AspNetUsers", "Id");
        }
    }
}
