using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeConstruction
{
    public class House
    {
        public Basement Basement { get; set; }
        public List<Walls> Walls { get; set; }
        public List<Door> Doors { get; set; }
        public List<Window> Windows { get; set; }
        public Roof Roof { get; set; }
        public Team Team { get; set; }



        public House(Team team)
        {
            Team = team;
        }
        
    }
}
