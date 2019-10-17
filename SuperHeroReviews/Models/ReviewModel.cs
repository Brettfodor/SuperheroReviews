namespace SuperHeroReviews.Models
{
    public class ReviewModel
    {
        public int ID { get; set; }
        public string Content { get; set; }
        public string ReviewerName { get; set; }
        public int Rating { get; set; }
        public string ReviewDate { get; set; }

        public int HeroModelID { get; set; }
        public virtual HeroModel HeroModel { get; set; }
        
        public ReviewModel()
        {
        }

        public ReviewModel(int id, string content, string reviewerName, int rating, string reviewDate, int heroModelID)
        {
            ID = id;
            Content = content;
            ReviewerName = reviewerName;
            Rating = rating;
            ReviewDate = reviewDate;
            HeroModelID = heroModelID;
        }
    }

}
