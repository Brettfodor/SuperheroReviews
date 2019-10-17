using Microsoft.AspNetCore.Mvc;
using SuperHeroReviews.Models;
using SuperHeroReviews.Repository;



namespace SuperHeroReviews.Controllers
{
    public class HeroController : Controller
    {
        IRepository<HeroModel> heroRepo;
        public HeroController(IRepository<HeroModel> heroRepo)
        {
            this.heroRepo = heroRepo;
        }

        public ViewResult HeroIndex()
        {
            var model = heroRepo.GetAll();

            return View(model);
        }


        public ViewResult Details(int id)
        {
            var model = heroRepo.GetByID(id);

            return View(model);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(HeroModel hero)
        {
            heroRepo.Create(hero);
            return RedirectToAction("HeroIndex");
        }

        [HttpGet]
        public ViewResult Delete(int id)
        {
            ViewBag.ID = id;
            var model = heroRepo.GetByID(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Delete(HeroModel hero)
        {
            heroRepo.Delete(hero);
            return RedirectToAction("HeroIndex");
        }

        [HttpGet]
        public ViewResult Edit(int id)
        {
            var model = heroRepo.GetByID(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(HeroModel hero)
        {
            heroRepo.Edit(hero);
            return RedirectToAction("HeroIndex");
        }

    }
}
