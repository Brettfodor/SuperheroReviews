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

    }
}
