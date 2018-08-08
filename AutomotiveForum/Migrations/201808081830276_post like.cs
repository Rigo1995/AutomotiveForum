namespace AutomotiveForum.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class postlike : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Fora", "PostLike", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Fora", "PostLike");
        }
    }
}
