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
                    Type = "Ale",
                    ImageUrl = "SpottedCow.jpg",
                    Company = "New Glarus",
                    AlcoholContent = "5.1",
                    Calories = 153
                },
                new Beer
                {
                    Name = "New Grist Gluten Free",
                    Type = "Ale",
                    ImageUrl = "NewGrist.jpg",
                    Company = "Lakefront Brewery",
                    AlcoholContent = "5.1",
                    Calories = 166
                },
                new Beer
                {
                    Name = "High Life",
                    Type = "Pilsner",
                    ImageUrl = "MillerHighLife.jpg",
                    Company = "Miller Coors",
                    AlcoholContent = "4.6",
                    Calories = 143,
                    BeerReviews = new List<BeerReviews> {
                                  new BeerReviews { Name = "A Beer Review", Rating = 9.5, Comments = "A nice, smooth beer!" }
                    }
                }
              );

        }
    }
}
