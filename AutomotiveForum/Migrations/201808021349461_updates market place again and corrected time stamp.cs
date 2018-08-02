namespace AutomotiveForum.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatesmarketplaceagainandcorrectedtimestamp : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MarketPlaces", "Date", c => c.DateTime());
            AlterColumn("dbo.MarketPlaces", "Price", c => c.Int(nullable: false));
            DropColumn("dbo.MarketPlaces", "Timestamp");
            DropColumn("dbo.MarketPlaces", "Topic");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MarketPlaces", "Topic", c => c.String());
            AddColumn("dbo.MarketPlaces", "Timestamp", c => c.DateTime());
            AlterColumn("dbo.MarketPlaces", "Price", c => c.String());
            DropColumn("dbo.MarketPlaces", "Date");
        }
    }
}
