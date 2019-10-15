using SuperHeroReviews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuperHeroReviews.Data;
using SuperHeroReviews.Repository;


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
            return db.Review.Count();
        }
        public void Create(ReviewModel review)
        {
            db.Review.Add(review);
            db.SaveChanges();
        }
        public void Delete(ReviewModel review)
        {
            db.Review.Remove(review);
            db.SaveChanges();
        }
        public void Edit(ReviewModel review)
        {
            db.Review.Update(review);
            db.SaveChanges();
        }
        public IEnumerable<ReviewModel> GetAll()
        {
            return db.Review.ToList();
        }
        public ReviewModel GetByID(int id)
        {
            return db.Review.Single(p => p.ID == id);
        }
        public IEnumerable<ReviewModel> GetByHeroID(int heroModelID)
        {
            var review = db.Review.Where(p => p.HeroModelID == heroModelID);
            return review;
        }
        public void Save()
        {
            db.SaveChanges();
        }
    }
}
