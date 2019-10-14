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

        public ViewResult AllReviews()
        {
            return View();
        }
        Repository<ReviewModel> reviewRepo;
        public ReviewController(Repository<ReviewModel> reviewRepo)
        {
            this.reviewRepo = reviewRepo;
        }

        public ViewResult ReviewIndex()
        {
            //reviewRepository reviewRepo = new reviewRepository();

            var model = reviewRepo.GetAll();

            return View(model);
        }


        public ViewResult Details(int id)
        {
            var model = reviewRepo.GetById(id);

            return View(model);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(ReviewModel review)
        {
            reviewRepo.Create(review);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ViewResult CreateByHeroModelID(int id)
        {
            ViewBag.HeroModelID = id;
            return View();
        }

        [HttpGet]
        public ViewResult Delete(int id)
        {
            var model = reviewRepo.GetById(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Delete(ReviewModel review)
        {
            reviewRepo.Delete(review);
            return RedirectToAction("Index");
        }
    }
}

