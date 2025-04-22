using Examen.DAL.Data;
using Examen.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.DAL.Repositories
{
    public class MatchRepository
    {
        private readonly AppDbContext _context;

        public MatchRepository()
        {
            _context = new AppDbContext();
        }
        public IEnumerable<Match> GetAll()
        {
            return _context.Matches;
        }
        public void Add(Match match)
        {
            _context.Matches.Add(match);
            _context.SaveChanges();
        }
        public void Update(Match match)
        {
            _context.Matches.Update(match);
            _context.SaveChanges();
        }
        public void Delete(Match match)
        {
            _context.Matches.Remove(match);
            _context.SaveChanges();
        }

    }
}
