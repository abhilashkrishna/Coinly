namespace Coinly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IcoTypeIDIntToByte : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Icoes", "IcoTypes_Id", "dbo.IcoTypes");
            DropIndex("dbo.Icoes", new[] { "IcoTypes_Id" });
            DropPrimaryKey("dbo.IcoTypes");
            AlterColumn("dbo.Icoes", "IcoTypeId", c => c.Byte(nullable: false));
            AlterColumn("dbo.Icoes", "IcoTypes_Id", c => c.Byte());
            AlterColumn("dbo.IcoTypes", "Id", c => c.Byte(nullable: false));
            AddPrimaryKey("dbo.IcoTypes", "Id");
            CreateIndex("dbo.Icoes", "IcoTypes_Id");
            AddForeignKey("dbo.Icoes", "IcoTypes_Id", "dbo.IcoTypes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Icoes", "IcoTypes_Id", "dbo.IcoTypes");
            DropIndex("dbo.Icoes", new[] { "IcoTypes_Id" });
            DropPrimaryKey("dbo.IcoTypes");
            AlterColumn("dbo.IcoTypes", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Icoes", "IcoTypes_Id", c => c.Int());
            AlterColumn("dbo.Icoes", "IcoTypeId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.IcoTypes", "Id");
            CreateIndex("dbo.Icoes", "IcoTypes_Id");
            AddForeignKey("dbo.Icoes", "IcoTypes_Id", "dbo.IcoTypes", "Id");
        }
    }
}
