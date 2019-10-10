using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperHeroReviews.Models
{
    public class HeroModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Content { get; set; }

        public virtual int ReviewID { get; set; }
        public virtual ReviewModel Review { get; set; }


        public virtual int UniverseID { get; set; }
        public virtual UniverseModel Universe { get; set; }


        public HeroModel()
        {

        }

        public HeroModel(int id, string name, string content, string image)
        {
            ID = id;
            Name = name;
            Content = content;
            Image = image;

        }
    }
}
