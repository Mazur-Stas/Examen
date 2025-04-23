using Examen.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Examen.Services
{
    public class MenuService
    {

        private readonly TeamAndMatchService _teammatchService;
        private readonly TournamentService _tournamentService;

        public MenuService()
        {
            _teammatchService = new TeamAndMatchService();
            _tournamentService = new TournamentService();
        }

        public void Menu()
        {
            string choice;
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("\n\n0.Exit ");
                Console.WriteLine("======= Examen =======");
                Console.WriteLine("1. Add Team");
                Console.WriteLine("2. Edit Team ");
                Console.WriteLine("3. Delete Team by Id");
                Console.WriteLine("4. Get all Teams");

                Console.WriteLine("5. Add new Tournament");
                Console.WriteLine("6. Edit Tournament");
                Console.WriteLine("7. Delete Tournament by Id");
                Console.WriteLine("8. Get all Tournaments ");

                Console.WriteLine("9. Add new Match");
                Console.WriteLine("10. Edit Match");
                Console.WriteLine("11. Delete Match by Id");
                Console.WriteLine("12. Get all Matches");

                Console.WriteLine("13. Get all Matches sort by date (Match Hisotry) ");
                Console.WriteLine("14. Ranking");


                choice = Console.ReadLine();
                switch (choice)
                {
                    case "0":

                        Console.WriteLine("Exit program");
                        isRunning = false;
                        break;

                    case "1":
                        Console.WriteLine("Enter Name:");
                        string name = Console.ReadLine();

                        Console.WriteLine("Enter City:");
                        string city = Console.ReadLine();

                        Console.WriteLine("Enter win count:");
                        string win = Console.ReadLine();
                        int.TryParse(win, out int res);

                        Console.Clear();
                        var team = new Team { Name = name, City = city , WinCount = res};
                        _teammatchService.AddTeam(team);
                        Console.WriteLine("Adding succeed");
                        break;

                    case "2":
                        Console.WriteLine("Enter Id to update:");
                        string s = Console.ReadLine();
                        int.TryParse(s, out int resId);

                        Console.WriteLine("Enter Name:");
                        string name1 = Console.ReadLine();

                        Console.WriteLine("Enter City:");
                        string city1 = Console.ReadLine();

                        Console.WriteLine("Enter win count:");
                        string win1 = Console.ReadLine();
                        int.TryParse(win1, out int res1);

                        Team tempT = new Team() {Name = name1,City = city1,WinCount = res1 };
                        Console.Clear();
                        _teammatchService.UpdateTeam(resId,tempT);
                        Console.WriteLine("Update succeed");
                        break;

                    case "3":
                        Console.WriteLine("Enter Id to delete:");
                        string del = Console.ReadLine();
                        int.TryParse(del, out int res2);

                        Console.Clear();
                        _teammatchService.DeleteByIdTeam(res2);
                        Console.WriteLine("Delete succeed");

                        break;

                    case "4":
                        Console.Clear();
                        _teammatchService.ShowAllTeam();                        
                        break;

                        //tournament
                    case "5":
                        Console.WriteLine("Enter Name:");
                        string name2 = Console.ReadLine();

                        Console.Clear();
                        var tournament = new Tournament { Name = name2 };
                        _tournamentService.AddTournamet(tournament);
                        Console.WriteLine("Adding succeed");
                        break;

                    case "6":
                        Console.WriteLine("Enter Id to update:");
                        string s1 = Console.ReadLine();
                        int.TryParse(s1, out int resId1);

                        Console.WriteLine("Enter Name:");
                        string name3 = Console.ReadLine();


                        var tempTo = new Tournament() { Name = name3 };
                        Console.Clear();
                        _tournamentService.UpdateTournament(resId1, tempTo);
                        Console.WriteLine("Update succeed");
                        break;

                    case "7":
                        Console.WriteLine("Enter Id to delete:");
                        string del1 = Console.ReadLine();
                        int.TryParse(del1, out int resdel);

                        Console.Clear();
                        _tournamentService.DeleteByIdTournament(resdel);
                        Console.WriteLine("Delete succeed");

                        break;

                    case "8":
                        Console.Clear();
                        _tournamentService.ShowAllTournament();
                        break;

                    case "9":
                        Console.WriteLine("Enter Date:");
                        string name4 = Console.ReadLine();

                        Console.WriteLine("Enter team 1 id");
                        string teamId1 = Console.ReadLine();
                        int.TryParse(teamId1, out int resId2);

                        Console.WriteLine("Enter team 2 id");
                        string teamId2 = Console.ReadLine();
                        int.TryParse(teamId2, out int resId3);

                        Console.WriteLine("Enter tournament id");
                        string tourId = Console.ReadLine();
                        int.TryParse(tourId, out int resId4);

                        Console.Clear();
                        var match = new Match { MatchDate = DateTime.Parse(name4), Team1Id = resId2, Team2Id = resId3 , TournamentId = resId4};
                        _teammatchService.AddMacth(match);
                        Console.WriteLine("Adding succeed");
                        break;

                    case "10":
                        Console.WriteLine("Enter Id to update:");
                        string s2= Console.ReadLine();
                        int.TryParse(s2, out int resIdM);

                        Console.WriteLine("Enter Date:");
                        string name5 = Console.ReadLine();

                        Console.WriteLine("Enter team 1 id");
                        string teamId11 = Console.ReadLine();
                        int.TryParse(teamId11, out int resId22);

                        Console.WriteLine("Enter team 2 id");
                        string teamId22 = Console.ReadLine();
                        int.TryParse(teamId22, out int resId33);

                        Console.WriteLine("Enter tournament id");
                        string tourId1 = Console.ReadLine();
                        int.TryParse(tourId1, out int resId44);

                        Console.Clear();
                        var match1 = new Match { MatchDate = DateTime.Parse(name5), Team1Id = resId22, Team2Id = resId33, TournamentId = resId44 };
                        _teammatchService.UpdateMatch(resIdM, match1);
                        Console.WriteLine("Updating succeed");
                        break;

                    case "11":
                        Console.WriteLine("Enter Id to delete:");
                        string del2 = Console.ReadLine();
                        int.TryParse(del2, out int res3);

                        Console.Clear();
                        _teammatchService.DeleteByIdMatch(res3);
                        Console.WriteLine("Delete succeed");

                        break;

                    case "12":
                        Console.Clear();
                        _teammatchService.ShowAllMatches();
                        break;

                    case "13":
                        Console.Clear();
                        _teammatchService.ShowAllMatchesSort();
                        break;

                    case "14":
                        Console.Clear();
                        _teammatchService.ShowRanking();
                        break;



                    default:
                        Console.WriteLine("error, try again.");
                        break;
                }
            }
        }
    }
}
