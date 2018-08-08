namespace AutomotiveForum.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedpricevalue : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MarketPlaces", "Price", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MarketPlaces", "Price", c => c.Int(nullable: false));
        }
    }
}
