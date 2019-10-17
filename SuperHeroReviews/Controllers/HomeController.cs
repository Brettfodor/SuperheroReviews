using Microsoft.AspNetCore.Mvc;

namespace SuperHeroReviews.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }

        public ViewResult About()
        {
            return View();
        }
    }
}
