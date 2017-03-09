using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyBeerBlog.Models
{
    public class MyBeerBlogDb : DbContext
    {
        public MyBeerBlogDb() : base("name=DefaultConnection")
        {

        }
        public DbSet<Beer> Beers { get; set; }
        public DbSet<BeerReviews> BeerReviews { get; set; }

    }
}