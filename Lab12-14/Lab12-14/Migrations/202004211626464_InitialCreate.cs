namespace Lab12_14.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CartName = c.String(),
                        sum = c.Double(nullable: false),
                        shop_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Shops", t => t.shop_Id)
                .Index(t => t.shop_Id);
            
            CreateTable(
                "dbo.Stocks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        quantity = c.Int(nullable: false),
                        Product_Id = c.Int(),
                        Cart_Id = c.Int(),
                        Shop_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.Product_Id)
                .ForeignKey("dbo.Carts", t => t.Cart_Id)
                .ForeignKey("dbo.Shops", t => t.Shop_Id)
                .Index(t => t.Product_Id)
                .Index(t => t.Cart_Id)
                .Index(t => t.Shop_Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        cost = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Shops",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Carts", "shop_Id", "dbo.Shops");
            DropForeignKey("dbo.Stocks", "Shop_Id", "dbo.Shops");
            DropForeignKey("dbo.Stocks", "Cart_Id", "dbo.Carts");
            DropForeignKey("dbo.Stocks", "Product_Id", "dbo.Products");
            DropIndex("dbo.Stocks", new[] { "Shop_Id" });
            DropIndex("dbo.Stocks", new[] { "Cart_Id" });
            DropIndex("dbo.Stocks", new[] { "Product_Id" });
            DropIndex("dbo.Carts", new[] { "shop_Id" });
            DropTable("dbo.Shops");
            DropTable("dbo.Products");
            DropTable("dbo.Stocks");
            DropTable("dbo.Carts");
        }
    }
}
