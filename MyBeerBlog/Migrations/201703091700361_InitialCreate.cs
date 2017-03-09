namespace MyBeerBlog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BeerReviews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Rating = c.Double(nullable: false),
                        Comments = c.String(),
                        BeerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Beers", t => t.BeerId, cascadeDelete: true)
                .Index(t => t.BeerId);
            
            CreateTable(
                "dbo.Beers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Type = c.String(),
                        ImageUrl = c.String(),
                        Company = c.String(),
                        AlcoholContent = c.String(),
                        Calories = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BeerReviews", "BeerId", "dbo.Beers");
            DropIndex("dbo.BeerReviews", new[] { "BeerId" });
            DropTable("dbo.Beers");
            DropTable("dbo.BeerReviews");
        }
    }
}
