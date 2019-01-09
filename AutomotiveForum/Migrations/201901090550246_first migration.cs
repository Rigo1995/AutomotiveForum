namespace AutomotiveForum.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstmigration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Fora", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.Fora", new[] { "UserId" });
            DropTable("dbo.Fora");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Fora",
                c => new
                    {
                        TopicId = c.Int(nullable: false, identity: true),
                        Topic = c.String(),
                        PostLike = c.Int(nullable: false),
                        UserId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.TopicId);
            
            CreateIndex("dbo.Fora", "UserId");
            AddForeignKey("dbo.Fora", "UserId", "dbo.AspNetUsers", "Id");
        }
    }
}
