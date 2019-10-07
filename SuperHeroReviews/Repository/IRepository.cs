using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace SuperHeroReviews.Repository
{
    public interface IRepository<T> where T :class
    {
        IEnumerable<T> GetAll();

        T GetById(int id);

        
    }
    
}
