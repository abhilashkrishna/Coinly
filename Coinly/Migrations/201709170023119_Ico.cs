namespace Coinly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Ico : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Icoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Industry = c.String(),
                        Description = c.String(),
                        IcoTypeId = c.Int(nullable: false),
                        IcoTypes_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.IcoTypes", t => t.IcoTypes_Id)
                .Index(t => t.IcoTypes_Id);
            
            CreateTable(
                "dbo.IcoTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Icoes", "IcoTypes_Id", "dbo.IcoTypes");
            DropIndex("dbo.Icoes", new[] { "IcoTypes_Id" });
            DropTable("dbo.IcoTypes");
            DropTable("dbo.Icoes");
        }
    }
}
