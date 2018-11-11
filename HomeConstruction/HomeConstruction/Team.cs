using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeConstruction
{
    public class Team
    {
        public TeamLeader TeamLeader { get; set; }
        public List<Worker> Workers { get; set; }
        public Team()
        {
            TeamLeader = new TeamLeader("Architect","Bill Johnson");
            Workers = new List<Worker>()
            {
                new Worker("Installer","Kine Dember"),
                new Worker("Electric","Dave Botson"),
                new Worker("Plumber","Bros Mario"),
            };
        }
        
    }
}
