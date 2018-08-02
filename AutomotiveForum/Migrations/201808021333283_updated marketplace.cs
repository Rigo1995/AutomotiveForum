namespace AutomotiveForum.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedmarketplace : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MarketPlaces", "ItemsForSale", c => c.String());
            AddColumn("dbo.MarketPlaces", "Price", c => c.String());
            AddColumn("dbo.MarketPlaces", "Description", c => c.String());
            DropColumn("dbo.MarketPlaces", "Items_For_Sale");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MarketPlaces", "Items_For_Sale", c => c.String());
            DropColumn("dbo.MarketPlaces", "Description");
            DropColumn("dbo.MarketPlaces", "Price");
            DropColumn("dbo.MarketPlaces", "ItemsForSale");
        }
    }
}
