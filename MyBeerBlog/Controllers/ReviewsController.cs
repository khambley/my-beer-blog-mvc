//using MyBeerBlog.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;

//namespace MyBeerBlog.Controllers
//{
//    public class ReviewsController : Controller
//    {
//        // GET: Reviews
//        public ActionResult Index()
//        {
//            var model =
//                from r in _reviews
//                orderby r.Name
//                select r;
//            return View(model);
//        }

//        // GET: Reviews/Details/5
//        public ActionResult Details(int id)
//        {
//            return View();
//        }

//        // GET: Reviews/Create
//        public ActionResult Create()
//        {
//            return View();
//        }

//        // POST: Reviews/Create
//        [HttpPost]
//        public ActionResult Create(FormCollection collection)
//        {
//            try
//            {
//                // TODO: Add insert logic here

//                return RedirectToAction("Index");
//            }
//            catch
//            {
//                return View();
//            }
//        }

//        // GET: Reviews/Edit/5
//        public ActionResult Edit(int id)
//        {
//            var review = _reviews.Single(r => r.Id == id);
        
//            return View(review);
//        }

//        // POST: Reviews/Edit/5
//        [HttpPost]
//        public ActionResult Edit(int id, FormCollection collection)
//        {
//            var review = _reviews.Single(r => r.Id == id);
//            if (TryUpdateModel(review))
//            {
//                // .. if successful, will save in a database later 
//                return RedirectToAction("Index"); //redirect back to Reviews/Index (Reviews Listing)

//            }
//            return View(review);
//        }

//        // GET: Reviews/Delete/5
//        public ActionResult Delete(int id)
//        {
//            return View();
//        }

//        // POST: Reviews/Delete/5
//        [HttpPost]
//        public ActionResult Delete(int id, FormCollection collection)
//        {
//            try
//            {
//                // TODO: Add delete logic here

//                return RedirectToAction("Index");
//            }
//            catch
//            {
//                return View();
//            }
//        }
//        static List<BeerReviews> _reviews = new List<BeerReviews>
//        {
//            new BeerReviews
//            {
//                Id = 1,
//                Name = "New Grist Gluten-Free",
//                Type = "Pilsner",
//                Rating = 10,
//                Comments = "This is a nice, smooth beer.",
                
//            },
//            new BeerReviews
//            {
//                Id = 2,
//                Name = "Spotted Cow Grand Cru (Thumbprint Series)",
//                Type = "Ale",
//                Rating = 9,
//                Comments = "This is a nice, smooth beer.",
                
//            },
//            new BeerReviews
//            {
//                Id = 3,
//                Name = "Wisconsin Red Pale",
//                Type = "Ale",
//                Rating = 8,
//                Comments = "This is a nice, smooth beer.",
                
//            }
//        };
//    }
//}
    

