using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuperHeroReviews.Models;
using SuperHeroReviews.Data;
using SuperHeroReviews.Repository;
using Microsoft.EntityFrameworkCore;

namespace SuperHeroReviews.Repository
{
    public class HeroRepository : IRepository<HeroModel>
    {
        private SuperContext db;
        public HeroRepository(SuperContext db)
        {
            this.db = db;
        }

        public int Count()
        {
            return db.Heroes.Count();
        }

        public void Create(HeroModel heroes)
        {
            db.Heroes.Add(heroes);
            db.SaveChanges();
        }

        public void Delete(HeroModel heroes)
        {
            db.Heroes.Remove(heroes);
            db.SaveChanges();
        }

        public void Edit(HeroModel heroes)
        {
            db.Heroes.Update(heroes);
            db.SaveChanges();
        }

        public IEnumerable<HeroModel> GetAll()
        {
            return db.Heroes.ToList();
        }

        public HeroModel GetByID(int id)
        {
            return db.Heroes.Single(p => p.ID == id);
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }

}
