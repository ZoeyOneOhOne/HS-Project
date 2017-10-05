namespace HSVersion1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddShopsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Shops",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Hours = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Shops");
        }
    }
}
