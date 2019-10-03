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

            new HeroModel(1, "IronMan", "Marvel");
            new HeroModel(2, "Thor", "Marvel");
            new HeroModel(3, "Spiderman", "Marvel");
            new HeroModel(4, "Black Widow", "Marvel");
            new HeroModel(5, "Black Panther", "Marvel");
            new HeroModel(6, "Wolverine", "Marvel");
            new HeroModel(7, "Thanos", "Marvel");
            new HeroModel(8, "Antman", "Marvel");
            new HeroModel(9, "Magneto", "Marvel");
            new HeroModel(10, "Mystique", "Marvel");
            new HeroModel(11, "Flash", "DC");
            new HeroModel(12, "Swamp Thing", "DC");
            new HeroModel(13, "Aquaman", "DC");
            new HeroModel(14, "Supergirl", "DC");
            new HeroModel(15, "Wonder Woman", "DC");
            new HeroModel(16, "Batman", "DC");
            new HeroModel(17, "Superman", "DC");
            new HeroModel(18, "Beast Boy", "DC");
            new HeroModel(19, "Cyborg", "DC");
            new HeroModel(20, "Nightwing", "DC");
            new HeroModel(21, "Joker", "DC");
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
