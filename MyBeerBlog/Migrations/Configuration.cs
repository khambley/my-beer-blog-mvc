namespace MyBeerBlog.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MyBeerBlog.Models.MyBeerBlogDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "MyBeerBlog.Models.MyBeerBlogDb";
        }

        protected override void Seed(MyBeerBlog.Models.MyBeerBlogDb context)
        {
            

              context.Beers.AddOrUpdate(
                p => p.Name,
                new Beer {
                    Name = "Spotted Cow Grand Cru",
                    BeerType = "Ale",
                    GrainType = "Barley, Wheat, Hops",
                    ImageUrl = "SpottedCow.jpg",
                    Company = "New Glarus",
                    AlcoholContent = "5.1",
                    Calories = 153,
                    Reviews = new List<BeerReviews> {
                              new BeerReviews {Rating = 9.5, Comments = "A nice, smooth beer!", ReviewerName="Katherine" }
                    }
                },
                new Beer
                {
                    Name = "New Grist Gluten Free",
                    BeerType = "Ale",
                    GrainType = "Sorghum, Rice, Hops",
                    ImageUrl = "NewGrist.jpg",
                    Company = "Lakefront Brewery",
                    AlcoholContent = "5.1",
                    Calories = 166
                },
                new Beer
                {
                    Name = "High Life",
                    BeerType = "Pilsner",
                    GrainType = "Barley, Wheat, Hops",
                    ImageUrl = "MillerHighLife.jpg",
                    Company = "Miller Coors",
                    AlcoholContent = "4.6",
                    Calories = 143,
                    Reviews = new List<BeerReviews> {
                              new BeerReviews {Rating = 9.5, Comments = "A nice, smooth beer!", ReviewerName="Katherine" }
                    }
                },
                new Beer
                {
                    Name = "Killians",
                    BeerType = "Red Ale",
                    GrainType = "Barley, Wheat, Hops",
                    ImageUrl = "#",
                    Company = "Coors",
                    AlcoholContent = "4.6",
                    Calories = 143,
                    Reviews = new List<BeerReviews> {
                              new BeerReviews {Rating = 9.5, Comments = "A nice, smooth beer!", ReviewerName="Katherine" }
                    }
                }
              );

        }
    }
}
