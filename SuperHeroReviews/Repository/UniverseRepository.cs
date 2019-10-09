using SuperHeroReviews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperHeroReviews.Repository
{
    public class UniverseRepository : Repository<UniverseModel>
    {
        public UniverseRepository(SuperContext context) : base(context)
        {
        }
    }
}
