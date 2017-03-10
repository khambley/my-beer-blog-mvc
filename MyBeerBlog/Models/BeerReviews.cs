using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyBeerBlog.Models
{
    public class BeerReviews
    {
        public int Id { get; set; }
        //public string Name { get; set; }
        public double Rating { get; set; }
        public string Comments { get; set; }
        public string ReviewerName { get; set; }
        public int BeerId { get; set; }



    }
}