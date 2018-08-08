namespace AutomotiveForum.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cost : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MarketPlaces", "Price", c => c.Single());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MarketPlaces", "Price", c => c.Double(nullable: false));
        }
    }
}
