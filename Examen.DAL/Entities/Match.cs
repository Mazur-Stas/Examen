using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Examen.DAL.Entities
{
    public class Match
    {
        public int Id { get; set; }

        public int Team1Id { get; set; }
        public Team Team1{ get; set; }

        public int Team2Id { get; set; }
        public Team Team2 { get; set; }

        public int TournamentId { get; set; }
        public Tournament Tournament { get; set; }
        public DateTime MatchDate { get; set; }

    }
}
