using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuperHeroReviews.Models;
using SuperHeroReviews.Models.HeroModel;
using Microsoft.AspNetCore.Mvc;

namespace SuperHeroReviews.Repository
{
    public class HeroRepository : IRepository<HeroModel>
    {
        public Dictionary<int, HeroModel> heroDictionary;

        public HeroRepository()
        {
            heroDictionary = new Dictionary<int, HeroModel>();

            heroDictionary.Add(1, (new HeroModel(1, "IronMan", "Marvel")));
            heroDictionary.Add(2, (new HeroModel(2, "Thor", "Marvel")));
            heroDictionary.Add(3, (new HeroModel(3, "Spiderman", "Marvel")));
            heroDictionary.Add(4, (new HeroModel(4, "Black Widow", "Marvel")));
            heroDictionary.Add(5, (new HeroModel(5, "Black Panther", "Marvel")));
            heroDictionary.Add(6, (new HeroModel(6, "Wolverine", "Marvel")));
            heroDictionary.Add(7, (new HeroModel(7, "Thanos", "Marvel")));
            heroDictionary.Add(8, (new HeroModel(8, "Antman", "Marvel")));
            heroDictionary.Add(9, (new HeroModel(9, "Magneto", "Marvel")));
            heroDictionary.Add(10, (new HeroModel(10, "Mystique", "Marvel")));
            heroDictionary.Add(11, (new HeroModel(11, "Flash", "DC")));
            heroDictionary.Add(12, (new HeroModel(12, "Swamp Thing", "DC")));
            heroDictionary.Add(13, (new HeroModel(13, "Aquaman", "DC")));
            heroDictionary.Add(14, (new HeroModel(14, "Supergirl", "DC")));
            heroDictionary.Add(15, (new HeroModel(15, "Wonder Woman", "DC")));
            heroDictionary.Add(16, (new HeroModel(16, "Batman", "DC")));
            heroDictionary.Add(17, (new HeroModel(17, "Superman", "DC")));
            heroDictionary.Add(18, (new HeroModel(18, "Beast Boy", "DC")));
            heroDictionary.Add(19, (new HeroModel(19, "Cyborg", "DC")));
            heroDictionary.Add(20, (new HeroModel(20, "Nightwing", "DC")));
            heroDictionary.Add(21, (new HeroModel(21, "Joker", "DC")));
        }

        public IEnumerable<HeroModel> GetAll()
        {
            return heroDictionary;
        }


        public HeroModel GetByID(int id)
        {
            //return heroDictionary.Single(c => c.ID == id);
            return heroDictionary[id];
        }
    }
}
