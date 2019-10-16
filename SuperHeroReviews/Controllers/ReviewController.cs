using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SuperHeroReviews.Models;
using SuperHeroReviews.Repository;

namespace SuperHeroReviews.Controllers
{
    public class ReviewController : Controller
    {
        IRepository<ReviewModel> reviewRepo;

        public ViewResult AllReviews()
        {
            return View();
        }

        public ReviewController(IRepository<ReviewModel> reviewRepo)
        {
            this.reviewRepo = reviewRepo;
        }

        public ViewResult ReviewIndex()
        {
            var model = reviewRepo.GetAll();

            return View(model);
        }


        public ViewResult Details(int id)
        {
            var model = reviewRepo.GetByID(id);

            return View(model);
        }

        //[HttpGet]
        //public ViewResult Create()
        //{
        //    return View();
        //}

        [HttpPost]
        public ActionResult Create(ReviewModel review)
        {
            reviewRepo.Create(review);
            return RedirectToAction("Details", "Hero", new { id = review.HeroModelID });
        }

        [HttpGet]
        public ViewResult CreateByHeroID(int id)
        {
            ViewBag.HeroModelID = id;
            return View();
        }

        [HttpGet]
        public ViewResult Delete(int id)
        {
            var model = reviewRepo.GetByID(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Delete(ReviewModel review)
        {
            reviewRepo.Delete(review);
            return RedirectToAction("Details", "Hero", new { id = review.HeroModelID });
        }
        [HttpGet]
        public ViewResult Edit(int id)
        {
            var model = reviewRepo.GetByID(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(ReviewModel review)
        {
            reviewRepo.Edit(review);
            return RedirectToAction("Details", "Hero", new { id = review.HeroModelID });
        }
    }
}

