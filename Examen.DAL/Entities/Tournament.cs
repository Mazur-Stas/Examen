using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.DAL.Entities
{
    public class Tournament
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Match> Matches { get; set; } = new List<Match>();
    }
}
