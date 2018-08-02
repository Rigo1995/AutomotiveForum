namespace AutomotiveForum.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class correctederrors : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MarketPlaces",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Timestamp = c.DateTime(),
                        Topic = c.String(),
                        Items_For_Sale = c.String(),
                        UserId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MarketPlaces", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.MarketPlaces", new[] { "UserId" });
            DropTable("dbo.MarketPlaces");
        }
    }
}
