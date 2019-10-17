using SuperHeroReviews.Models;
using System.Collections.Generic;
using System.Linq;
using SuperHeroReviews.Data;


namespace SuperHeroReviews.Repository
{
    public class ReviewRepository : IRepository<ReviewModel>
    {
        private SuperContext db;
        public ReviewRepository(SuperContext db)
        {
            this.db = db;
        }

        public int Count()
        {
            return db.Reviews.Count();
        }

        public void Create(ReviewModel review)
        {
            db.Reviews.Add(review);
            db.SaveChanges();
        }

        public void Delete(ReviewModel review)
        {
            db.Reviews.Remove(review);
            db.SaveChanges();
        }

        public void Edit(ReviewModel review)
        {
            db.Reviews.Update(review);
            db.SaveChanges();
        }

        public IEnumerable<ReviewModel> GetAll()
        {
            return db.Reviews.ToList();
        }

        public ReviewModel GetByID(int id)
        {
            return db.Reviews.Single(p => p.ID == id);
        }

        public IEnumerable<ReviewModel> GetByHeroID(int heroModelID)
        {
            var review = db.Reviews.Where(p => p.HeroModelID == heroModelID);
            return review;
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
