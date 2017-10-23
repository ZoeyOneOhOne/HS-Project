namespace HSVersion1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddReservationTable2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reservations", "TimeStart", c => c.String());
            AddColumn("dbo.Reservations", "TimeEnd", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reservations", "TimeEnd");
            DropColumn("dbo.Reservations", "TimeStart");
        }
    }
}
