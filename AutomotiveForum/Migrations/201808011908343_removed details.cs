namespace AutomotiveForum.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeddetails : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Fora", "Details");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Fora", "Details", c => c.String());
        }
    }
}
