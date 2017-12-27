namespace WPFDemo_001.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tckn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Personels", "TCKN", c => c.String(maxLength: 11));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Personels", "TCKN");
        }
    }
}
