using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SuperHeroReviews.Models;
using SuperHeroReviews.Repository;


namespace SuperHeroReviews.Controllers
{
    public class HeroController : Controller
    {
        public ViewResult HeroIndex()
        {
            HeroRepository heroRepo = new HeroRepository();

            var model = heroRepo.GetAll();

            return View(model);
        }

    }
}
