using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SuperHeroReviews.Models
{
    public class UniverseModel
    {
        public int ID { get; set; }
        public string Universe { get; set; }
        public string Faction { get; set; }

        public UniverseModel()
        {

        }

        public UniverseModel(int id, string comicUniverse, string faction)
        {
            ID = id;
            Universe = comicUniverse;
            Faction = faction;

        }
    }
}
