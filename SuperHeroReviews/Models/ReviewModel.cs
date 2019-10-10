using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SuperHeroReviews.Models
{
    public class ReviewModel
    {
        public int ID { get; set; }
        public string Review { get; set; }

        public ReviewModel()
        {

        }

        public ReviewModel(int id, string userReview)
        {
            ID = id;
            Review = userReview;
        }
    }

}
