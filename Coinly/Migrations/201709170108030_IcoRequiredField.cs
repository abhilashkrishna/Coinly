namespace Coinly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IcoRequiredField : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Icoes", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Icoes", "Industry", c => c.String(nullable: false));
            AlterColumn("dbo.IcoTypes", "Type", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.IcoTypes", "Type", c => c.String());
            AlterColumn("dbo.Icoes", "Industry", c => c.String());
            AlterColumn("dbo.Icoes", "Name", c => c.String());
        }
    }
}
