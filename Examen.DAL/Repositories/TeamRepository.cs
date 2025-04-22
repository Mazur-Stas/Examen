using Examen.DAL.Data;
using Examen.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.DAL.Repositories
{
    public class TeamRepository
    {
        private readonly AppDbContext _context;

        public TeamRepository()
        {
            _context = new AppDbContext();
        }
        public IEnumerable<Team> GetAll()
        {
            return _context.Teams;
        }
        public void Add(Team team)
        {
            _context.Teams.Add(team);
            _context.SaveChanges();
        }
        public void Update(Team team)
        {
            _context.Teams.Update(team);
            _context.SaveChanges();
        }
        public void Delete(Team team)
        {
            _context.Teams.Remove(team);
            _context.SaveChanges();
        }
    }
}
