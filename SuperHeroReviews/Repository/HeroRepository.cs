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

            heroList.Add(new HeroModel(1, "IronMan", "Marvel"));
            heroList.Add(new HeroModel(2, "Thor", "Marvel"));
            heroList.Add(new HeroModel(3, "Spiderman", "Marvel"));
            heroList.Add(new HeroModel(4, "Black Widow", "Marvel"));
            heroList.Add(new HeroModel(5, "Black Panther", "Marvel"));
            heroList.Add(new HeroModel(6, "Wolverine", "Marvel"));
            heroList.Add(new HeroModel(7, "Thanos", "Marvel"));
            heroList.Add(new HeroModel(8, "Antman", "Marvel"));
            heroList.Add(new HeroModel(9, "Magneto", "Marvel"));
            heroList.Add(new HeroModel(10, "Mystique", "Marvel"));
            heroList.Add(new HeroModel(11, "Flash", "DC"));
            heroList.Add(new HeroModel(12, "Swamp Thing", "DC"));
            heroList.Add(new HeroModel(13, "Aquaman", "DC"));
            heroList.Add(new HeroModel(14, "Supergirl", "DC"));
            heroList.Add(new HeroModel(15, "Wonder Woman", "DC"));
            heroList.Add(new HeroModel(16, "Batman", "DC"));
            heroList.Add(new HeroModel(17, "Superman", "DC"));
            heroList.Add(new HeroModel(18, "Beast Boy", "DC"));
            heroList.Add(new HeroModel(19, "Cyborg", "DC"));
            heroList.Add(new HeroModel(20, "Nightwing", "DC"));
            heroList.Add(new HeroModel(21, "Joker", "DC"));
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
