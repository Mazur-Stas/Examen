using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen.DAL.Entities;
using Examen.DAL.Repositories;

namespace Examen.Services
{
    public class TournamentService
    {
        private readonly TournamentRepository _tournamentRepository;

        public TournamentService()
        {
            _tournamentRepository = new TournamentRepository();
        }

        public List<Tournament> GetAllTournament()
        {
            return _tournamentRepository.GetAll().ToList();
        }
        public void AddTournamet(Tournament tournament)
        {
            _tournamentRepository.Add(tournament);
        }
        public void UpdateTournament(int Id, Tournament tournament)
        {
            var tr = _tournamentRepository.GetAll().FirstOrDefault(o => o.Id == Id);
            if (tr != null)
            {
                tr.Name = tournament.Name;
                _tournamentRepository.Update(tr);
            }
        }
        public void DeleteByIdTournament(int id)
        {
            var tournament = _tournamentRepository.GetAll()
                       .FirstOrDefault(t => t.Id == id);
            _tournamentRepository.Delete(tournament);
        }
        public void ShowAllTournament()
        {
            var tournaments = GetAllTournament();
            foreach (var tournament in tournaments)
            {
                Console.WriteLine($"\nId: {tournament.Id}, Name: {tournament.Name}, Matches : ");} //доробити
        }
    }
}
