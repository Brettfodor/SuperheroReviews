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

        public virtual ICollection<ReviewModel> Reviews { get; set; }


        public virtual int UniverseModelID { get; set; }
        public virtual UniverseModel Universe { get; set; }


        public HeroModel()
        {

        }

        public HeroModel(int id, string name, string content, string image, ICollection<ReviewModel> reviews, int universeModelID) 
        {
            ID = id;
            Name = name;
            Content = content;
            Image = image;
            Reviews = reviews;
            UniverseModelID = universeModelID;

        }
    }
}
