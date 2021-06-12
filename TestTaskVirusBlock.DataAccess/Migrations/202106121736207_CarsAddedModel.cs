namespace TestTaskVirusBlock.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CarsAddedModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Brand = c.String(nullable: false, maxLength: 100),
                        Model = c.String(nullable: false, maxLength: 100),
                        YearCreation = c.DateTime(nullable: false),
                        Color = c.String(maxLength: 100),
                        IsAutomaticTransmission = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Cars");
        }
    }
}
