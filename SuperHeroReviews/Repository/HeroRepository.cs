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
        public Dictionary<int, HeroModel> heroDictionary;

        public HeroRepository()
        {
            heroDictionary = new Dictionary<int, HeroModel>();

            heroDictionary.Add(1, (new HeroModel("IronMan", "Marvel")));
            heroDictionary.Add(2, (new HeroModel("Thor", "Marvel")));
            heroDictionary.Add(3, (new HeroModel("Spiderman", "Marvel")));
            heroDictionary.Add(4, (new HeroModel("Black Widow", "Marvel")));
            heroDictionary.Add(5, (new HeroModel("Black Panther", "Marvel")));
            heroDictionary.Add(6, (new HeroModel("Wolverine", "Marvel")));
            heroDictionary.Add(7, (new HeroModel("Thanos", "Marvel")));
            heroDictionary.Add(8, (new HeroModel("Antman", "Marvel")));
            heroDictionary.Add(9, (new HeroModel("Magneto", "Marvel")));
            heroDictionary.Add(10, (new HeroModel("Mystique", "Marvel")));
            heroDictionary.Add(11, (new HeroModel("Flash", "DC")));
            heroDictionary.Add(12, (new HeroModel("Swamp Thing", "DC")));
            heroDictionary.Add(13, (new HeroModel("Aquaman", "DC")));
            heroDictionary.Add(14, (new HeroModel("Supergirl", "DC")));
            heroDictionary.Add(15, (new HeroModel("Wonder Woman", "DC")));
            heroDictionary.Add(16, (new HeroModel("Batman", "DC")));
            heroDictionary.Add(17, (new HeroModel("Superman", "DC")));
            heroDictionary.Add(18, (new HeroModel("Beast Boy", "DC")));
            heroDictionary.Add(19, (new HeroModel("Cyborg", "DC")));
            heroDictionary.Add(20, (new HeroModel("Nightwing", "DC")));
            heroDictionary.Add(21, (new HeroModel("Joker", "DC")));
        }

        public IEnumerable<HeroModel> GetAll()
        {
            return heroDictionary;
        }

        public HeroModel GetById(string name)
        {
            return heroDictionary.Single(c => c.Name == name);
        }
    }
}
