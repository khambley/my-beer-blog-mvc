using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyBeerBlog.Models
{
    public class Beer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public string Type { get; set; }
        public string GrainType { get; set; }
        public string BeerType { get; set; }
        public string ImageUrl { get; set; }
        public string Company { get; set; }
        public string AlcoholContent { get; set; }
        public int Calories { get; set; }
        public ICollection<BeerReviews> Reviews { get; set; }


    }
}