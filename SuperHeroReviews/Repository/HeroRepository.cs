using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuperHeroReviews.Models;
using SuperHeroReviews.Models.HeroModel;

namespace SuperHeroReviews.Repository
{
    public class HeroRepository : IRepository<HeroModel>
    {
        public List<HeroModel> heroList;

        public HeroRepository()
        {
            heroList = new List<HeroModel>();

            new HeroModel(1, "IronMan");
            new HeroModel(2, "Flash");
            new HeroModel(3, "Spiderman");
        }

        public IEnumerable<HeroModel> GetAll()
        {
            return heroList;
        }

        public HeroModel GetById(int id)
        {
            return heroList.Single(c => c.ID == id);
        }
    }
}
