namespace HSVersion1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Reservations : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reservations", "Date", c => c.DateTime(nullable: false));
            DropColumn("dbo.Reservations", "TimeStart");
            DropColumn("dbo.Reservations", "TimeEnd");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reservations", "TimeEnd", c => c.String());
            AddColumn("dbo.Reservations", "TimeStart", c => c.String());
            DropColumn("dbo.Reservations", "Date");
        }
    }
}
