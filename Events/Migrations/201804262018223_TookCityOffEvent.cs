namespace Events.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TookCityOffEvent : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Events", "City");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Events", "City", c => c.String());
        }
    }
}
