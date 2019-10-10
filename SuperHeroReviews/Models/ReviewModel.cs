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
        public string ReviewerName { get; set; }
        public int Rating { get; set; }
        public string ReviewDate { get; set; }

        public virtual int HeroModelID { get; set; }
        public virtual HeroModel HeroModel { get; set; }

        public ReviewModel()
        {

        }

        public ReviewModel(int id, string userReview, string reviewerName, int rating, string reviewDate, int heroModelID)
        {
            ID = id;
            Review = userReview;
            ReviewerName = reviewerName;
            Rating = rating;
            ReviewDate = reviewDate;
            HeroModelID = heroModelID;
        }
    }

}
