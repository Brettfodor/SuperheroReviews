using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SuperHeroReviews.Models.HeroModel;
using SuperHeroReviews.Repository;



namespace SuperHeroReviews.Controllers
{
    public class HeroController : Controller
    {

        //IRepository<HeroModel> heroRepo;
        //public HeroController(IRepository<HeroModel> heroRepo)
        //{
        //    this.heroRepo = heroRepo;
        //}

        //public ViewResult HeroIndex()
        //{
        //    //HeroRepository heroRepo = new HeroRepository();

        //    var model = heroRepo.GetAll();

        //    return View(model);
        //}


        //public ViewResult Details(int id)
        //{
        //    var model = heroRepo.GetById(id);

        //    return View(model);
        //}

    }
}
