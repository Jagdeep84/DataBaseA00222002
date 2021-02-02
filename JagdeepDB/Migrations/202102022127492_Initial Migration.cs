namespace JagdeepDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        categoryName = c.String(),
                        description = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        companyName = c.String(),
                        contactTitle = c.String(),
                        address = c.String(),
                        city = c.String(),
                        region = c.String(),
                        postalCode = c.String(),
                        country = c.String(),
                        phone = c.String(),
                        fax = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Employee",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        firstName = c.String(),
                        lastName = c.String(),
                        title = c.String(),
                        titleOfCourtesy = c.String(),
                        address = c.String(),
                        city = c.String(),
                        region = c.String(),
                        postalCode = c.String(),
                        coutnry = c.String(),
                        homePhone = c.String(),
                        extension = c.String(),
                        photo = c.String(),
                        notes = c.String(maxLength: 4000),
                        reportTo = c.String(),
                        photoPath = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Territory",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        territoryDescription = c.String(maxLength: 4000),
                        region_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Region", t => t.region_ID)
                .Index(t => t.region_ID);
            
            CreateTable(
                "dbo.Region",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        regionDescription = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.OrderDetail",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        unitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        quantity = c.Int(nullable: false),
                        discount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        product_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Product", t => t.product_ID)
                .Index(t => t.product_ID);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        productName = c.String(),
                        quantityPerLabel = c.Int(nullable: false),
                        unitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        unitsInStocks = c.Int(nullable: false),
                        unitsOnOrder = c.Int(nullable: false),
                        reorderLevel = c.Int(nullable: false),
                        dicounted = c.Decimal(nullable: false, precision: 18, scale: 2),
                        category_ID = c.Int(),
                        supplier_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Category", t => t.category_ID)
                .ForeignKey("dbo.Supplier", t => t.supplier_ID)
                .Index(t => t.category_ID)
                .Index(t => t.supplier_ID);
            
            CreateTable(
                "dbo.Supplier",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        companyName = c.String(),
                        contactName = c.String(),
                        contactTitle = c.String(),
                        Address = c.String(),
                        city = c.String(),
                        region = c.String(),
                        postalCode = c.String(),
                        country = c.String(),
                        phone = c.String(),
                        fax = c.Int(nullable: false),
                        homepage = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Order",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        weight = c.Single(nullable: false),
                        shipVia = c.String(),
                        shipName = c.String(),
                        shipAddress = c.String(),
                        shipCity = c.String(),
                        shipRegion = c.String(),
                        shipPostalCode = c.String(),
                        shipCOuntry = c.String(),
                        customer_ID = c.Int(),
                        employee_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Customer", t => t.customer_ID)
                .ForeignKey("dbo.Employee", t => t.employee_ID)
                .Index(t => t.customer_ID)
                .Index(t => t.employee_ID);
            
            CreateTable(
                "dbo.Shipper",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        companyName = c.String(),
                        phone = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TerritoryEmployee",
                c => new
                    {
                        Territory_ID = c.Int(nullable: false),
                        Employee_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Territory_ID, t.Employee_ID })
                .ForeignKey("dbo.Territory", t => t.Territory_ID, cascadeDelete: true)
                .ForeignKey("dbo.Employee", t => t.Employee_ID, cascadeDelete: true)
                .Index(t => t.Territory_ID)
                .Index(t => t.Employee_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Order", "employee_ID", "dbo.Employee");
            DropForeignKey("dbo.Order", "customer_ID", "dbo.Customer");
            DropForeignKey("dbo.OrderDetail", "product_ID", "dbo.Product");
            DropForeignKey("dbo.Product", "supplier_ID", "dbo.Supplier");
            DropForeignKey("dbo.Product", "category_ID", "dbo.Category");
            DropForeignKey("dbo.Territory", "region_ID", "dbo.Region");
            DropForeignKey("dbo.TerritoryEmployee", "Employee_ID", "dbo.Employee");
            DropForeignKey("dbo.TerritoryEmployee", "Territory_ID", "dbo.Territory");
            DropIndex("dbo.TerritoryEmployee", new[] { "Employee_ID" });
            DropIndex("dbo.TerritoryEmployee", new[] { "Territory_ID" });
            DropIndex("dbo.Order", new[] { "employee_ID" });
            DropIndex("dbo.Order", new[] { "customer_ID" });
            DropIndex("dbo.Product", new[] { "supplier_ID" });
            DropIndex("dbo.Product", new[] { "category_ID" });
            DropIndex("dbo.OrderDetail", new[] { "product_ID" });
            DropIndex("dbo.Territory", new[] { "region_ID" });
            DropTable("dbo.TerritoryEmployee");
            DropTable("dbo.Shipper");
            DropTable("dbo.Order");
            DropTable("dbo.Supplier");
            DropTable("dbo.Product");
            DropTable("dbo.OrderDetail");
            DropTable("dbo.Region");
            DropTable("dbo.Territory");
            DropTable("dbo.Employee");
            DropTable("dbo.Customer");
            DropTable("dbo.Category");
        }
    }
}
