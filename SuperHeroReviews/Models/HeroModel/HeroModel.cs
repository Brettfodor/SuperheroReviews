using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace SuperHeroReviews.Models.HeroModel
{
    public class HeroModel 
    {
        int ID { get;  set;  }
        string Name { get; set; }
        string Image { get; set; }
        string Review { get; set; }
        string Content { get; set; }
    }
}
