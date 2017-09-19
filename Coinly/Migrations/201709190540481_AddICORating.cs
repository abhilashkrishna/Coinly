namespace Coinly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddICORating : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Icoes", "Rating", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Icoes", "Rating");
        }
    }
}
