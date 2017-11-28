namespace HSVersion1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RedoingShops : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Shops");
        }
        
        public override void Down()
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
    }
}
