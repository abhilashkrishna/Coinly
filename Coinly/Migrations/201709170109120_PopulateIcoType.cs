namespace Coinly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateIcoType : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO IcoTypes(Type) VALUES('Platform')");
            Sql("INSERT INTO IcoTypes(Type) VALUES('Currency')");
            Sql("INSERT INTO IcoTypes(Type) VALUES('Application')");
        }
        
        public override void Down()
        {
        }
    }
}
