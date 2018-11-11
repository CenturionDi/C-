using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeConstruction
{
    class Program
    {
        static void Main(string[] args)
        {
            Team team = new Team();
            House house = new House(team);

            team.Workers[0].BuildPart(house);
            team.Workers[1].BuildPart(house);
            team.Workers[2].BuildPart(house);
            team.Workers[0].BuildPart(house);
            team.TeamLeader.BuildPart(house);
            team.Workers[2].BuildPart(house);
           
            Console.ReadLine();
        }
    }
}
