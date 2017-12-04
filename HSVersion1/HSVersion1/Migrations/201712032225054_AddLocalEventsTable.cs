namespace HSVersion1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLocalEventsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LocalEvents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Event = c.String(),
                        Description = c.String(),
                        Location = c.String(),
                        Time = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.LocalEvents");
        }
    }
}
