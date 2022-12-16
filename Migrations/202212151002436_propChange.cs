namespace MVCAssignment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class propChange : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Products", name: "SubCategories_SubCategoryId", newName: "SubCategory_SubCategoryId");
            RenameIndex(table: "dbo.Products", name: "IX_SubCategories_SubCategoryId", newName: "IX_SubCategory_SubCategoryId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Products", name: "IX_SubCategory_SubCategoryId", newName: "IX_SubCategories_SubCategoryId");
            RenameColumn(table: "dbo.Products", name: "SubCategory_SubCategoryId", newName: "SubCategories_SubCategoryId");
        }
    }
}
