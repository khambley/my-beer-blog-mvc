﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyBeerBlog.Models
{
    public class BeerReviews
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Rating { get; set; }
        public string Comments { get; set; }


    }
}