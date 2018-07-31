namespace AutomotiveForum.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class created_comment_model_and_controller1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Fora", "Details", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Fora", "Details");
        }
    }
}
