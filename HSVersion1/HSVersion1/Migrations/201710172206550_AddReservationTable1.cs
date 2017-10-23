namespace HSVersion1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddReservationTable1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Reservations", "TimeStart");
            DropColumn("dbo.Reservations", "TimeEnd");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reservations", "TimeEnd", c => c.Single(nullable: false));
            AddColumn("dbo.Reservations", "TimeStart", c => c.Single(nullable: false));
        }
    }
}
