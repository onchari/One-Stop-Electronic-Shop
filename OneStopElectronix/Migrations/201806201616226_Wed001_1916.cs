namespace OneStopElectronix.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Wed001_1916 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MainCategories",
                c => new
                    {
                        MainCategoryId = c.Int(nullable: false, identity: true),
                        MainCategoriesName = c.String(),
                        MainCategoriesDescription = c.String(),
                    })
                .PrimaryKey(t => t.MainCategoryId);
            
            CreateTable(
                "dbo.SubCategories",
                c => new
                    {
                        SubCategoryId = c.Int(nullable: false, identity: true),
                        SubCategoryName = c.String(),
                        SubCategoryDescription = c.String(),
                        MainCategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SubCategoryId)
                .ForeignKey("dbo.MainCategories", t => t.MainCategoryId, cascadeDelete: true)
                .Index(t => t.MainCategoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SubCategories", "MainCategoryId", "dbo.MainCategories");
            DropIndex("dbo.SubCategories", new[] { "MainCategoryId" });
            DropTable("dbo.SubCategories");
            DropTable("dbo.MainCategories");
        }
    }
}
