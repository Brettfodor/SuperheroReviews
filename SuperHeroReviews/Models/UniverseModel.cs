using System.Collections.Generic;

namespace SuperHeroReviews.Models
{
    public class UniverseModel
    {
        public int ID { get; set; }
        public string Universe { get; set; }
        public string Faction { get; set; }

        public virtual ICollection<HeroModel> Heroes { get; set; }

        public UniverseModel()
        {
        }

        public UniverseModel(int id, string universe, ICollection<HeroModel> heroes)
        {
            ID = id;
            Universe = universe;
            Heroes = heroes;
        }
    }
}
