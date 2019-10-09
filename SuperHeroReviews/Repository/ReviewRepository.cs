using SuperHeroReviews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperHeroReviews.Repository
{
    public class ReviewRepository : Repository<ReviewModel>
    {
        public ReviewRepository(SuperContext context) : base(context)
        {
        }
    }
}
