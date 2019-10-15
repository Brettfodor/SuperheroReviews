using SuperHeroReviews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuperHeroReviews.Data;

namespace SuperHeroReviews.Repository
{
    public class UniverseRepository : IRepository<UniverseModel>
    {
        private SuperContext db;
        public UniverseRepository(SuperContext db)
        {
            this.db = db;
        }
        public int Count()
        {
            return db.Universe.Count();
        }
        public void Create(UniverseModel universe)
        {
            db.Universe.Add(universe);
            db.SaveChanges();
        }
        public void Delete(UniverseModel universe)
        {
            db.Universe.Remove(universe);
            db.SaveChanges();
        }
        public void Edit(UniverseModel universe)
        {
            db.Universe.Update(universe);
            db.SaveChanges();
        }
        public IEnumerable<UniverseModel> GetAll()
        {
            return db.Universe.ToList();
        }
        public UniverseModel GetByID(int id)
        {
            return db.Universe.Single(p => p.ID == id);
        }
        public IEnumerable<UniverseModel> GetByHeroID(int id)
        {
            throw new NotImplementedException();
        }
        public void Save()
        {
            db.SaveChanges();
        }
    }
}
