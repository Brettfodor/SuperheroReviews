using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace SuperHeroReviews.Models.HeroModel
{
    public class HeroModel 
    {
        public int ID { get;  set;  }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Review { get; set; }
        public string Content { get; set; }
        public string Universe { get; set; }


        public HeroModel()
        {

        }

        public HeroModel(string name, string universe )
        {
         
            Name = name;
            Universe = universe;
        }
    }
    

    

   

}
