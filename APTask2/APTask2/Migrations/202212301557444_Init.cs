namespace APTask2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.InventDims",
                c => new
                    {
                        InventDimId = c.String(nullable: false, maxLength: 20),
                        InventSiteId = c.String(maxLength: 10),
                        InventLocationId = c.String(maxLength: 10),
                        WMSLocationId = c.String(maxLength: 10),
                        InventBatchId = c.String(maxLength: 20),
                        WMSPalletId = c.String(maxLength: 18),
                        InventColorId = c.String(maxLength: 10),
                        InventSerialId = c.String(maxLength: 20),
                        InventSizeId = c.String(maxLength: 10),
                        RecordId = c.Long(nullable: false, identity: true),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        CreatedBy = c.String(maxLength: 5),
                        ModifiedBy = c.String(maxLength: 5),
                    })
                .PrimaryKey(t => t.InventDimId);
            
            CreateTable(
                "dbo.InventLocations",
                c => new
                    {
                        InventLocationId = c.String(nullable: false, maxLength: 10),
                        InventSiteId = c.String(maxLength: 10),
                        Name = c.String(maxLength: 140),
                        CreateDateTime = c.DateTime(nullable: false),
                        UpdateDateTime = c.DateTime(nullable: false),
                        RecordId = c.Long(nullable: false, identity: true),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        CreatedBy = c.String(maxLength: 5),
                        ModifiedBy = c.String(maxLength: 5),
                    })
                .PrimaryKey(t => t.InventLocationId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.InventLocations");
            DropTable("dbo.InventDims");
        }
    }
}
