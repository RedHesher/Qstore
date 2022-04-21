namespace Qstore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddQuantityToProduct_Order : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Product_Order", "Quantity", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Product_Order", "Quantity");
        }
    }
}
