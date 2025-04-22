using Examen.DAL.Data;
using Examen.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.DAL.Repositories
{
    public class TournamentRepository
    {
        private readonly AppDbContext _context;

        public TournamentRepository()
        {
            _context = new AppDbContext();
        }
        public IEnumerable<Tournament> GetAll()
        {
            return _context.Tournaments;
        }
        public void Add(Tournament tournament)
        {
            _context.Tournaments.Add(tournament);
            _context.SaveChanges();
        }
        public void Update(Tournament tournament)
        {
            _context.Tournaments.Update(tournament);
            _context.SaveChanges();
        }
        public void Delete(Tournament tournament)
        {
            _context.Tournaments.Remove(tournament);
            _context.SaveChanges();
        }
    }
}
