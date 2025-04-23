using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen.DAL.Entities;
using Examen.DAL.Repositories;

namespace Examen.Services
{
    public class TeamAndMatchService
    {
        private readonly TeamRepository _teamRepository;
        private readonly MatchRepository _matchRepository;


        public TeamAndMatchService()
        {
            _teamRepository = new TeamRepository();
            _matchRepository = new MatchRepository();
        }
        // ==============  TEAMS  ==============

        public List<Team> GetAllTeam()
        {
            return _teamRepository.GetAll().ToList();
        }
        public void AddTeam(Team team)
        {
            _teamRepository.Add(team);
        }
        public void UpdateTeam(int Id, Team team)
        {
            var tm = _teamRepository.GetAll().FirstOrDefault(o => o.Id == Id);
            if (tm != null)
            {
                tm.Name = team.Name;
                tm.City = team.City;
                tm.WinCount = team.WinCount;

                _teamRepository.Update(tm);
            }
        }
        public void DeleteByIdTeam(int id)
        {
            var team = _teamRepository.GetAll()
                       .FirstOrDefault(t => t.Id == id);
            _teamRepository.Delete(team);
        }
        public void ShowAllTeam()
        {
            var teams = GetAllTeam();
            foreach (var team in teams)
            {
                Console.WriteLine($"\nId: {team.Id}, Name: {team.Name}, City: {team.City} , Win coumt: {team.WinCount}");
            }
        }

        // ==============  Matches  ==============

        public List<Match> GetAllMatch()
        {
            return _matchRepository.GetAll().ToList();
        }
        public void AddMacth(Match match)
        {
            _matchRepository.Add(match);
        }

        public void UpdateMatch(int Id, Match match)
        {
            var mt = _matchRepository.GetAll().FirstOrDefault(o => o.Id == Id);
            if (mt != null)
            {

                mt.MatchDate = match.MatchDate;
                mt.Team1Id = match.Team1Id;
                mt.Team2Id = match.Team2Id;
                mt.TournamentId = match.TournamentId;
                _matchRepository.Update(mt);
            }
        }
        public void DeleteByIdMatch(int id)
        {
            var match = _matchRepository.GetAll()
                       .FirstOrDefault(t => t.Id == id);
            _matchRepository.Delete(match);
        }
        public void ShowAllMatches()
        {
            var matches = GetAllMatch();
            foreach (var match in matches)
            {
                Console.WriteLine($"\nId: {match.Id}, Match: {match.Team1.Name} VS. {match.Team2.Name}, Date: {match.MatchDate} ");
            }
        }

    }
}
