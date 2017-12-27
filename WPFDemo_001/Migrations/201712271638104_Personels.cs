namespace WPFDemo_001.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Personels : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Persons", newName: "Personels");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Personels", newName: "Persons");
        }
    }
}
