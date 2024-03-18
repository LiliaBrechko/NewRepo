using GYM.Infrastructure;
using GYM.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GYM.Repositories
{
    public class TrainingSessionRepository : Repository<TrainingSession>
    {
        public override IEnumerable<TrainingSession> GetAll(params Expression<Func<TrainingSession, object>>[] includes)
        {
            using (DBContextGym db = new DBContextGym())
            {
                IQueryable<TrainingSession> set = db.Set<TrainingSession>();

                set = set.Include(p => p.Sets).ThenInclude(s => s.Exercise);

                return set.ToArray();
            }
        }
    }
}
