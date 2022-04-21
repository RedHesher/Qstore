namespace Qstore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveKeyFromProductInProduct_Order : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Product_Order");
            AlterColumn("dbo.Product_Order", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Product_Order", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Product_Order");
            AlterColumn("dbo.Product_Order", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Product_Order", new[] { "OrderId", "ProductId" });
        }
    }
}
