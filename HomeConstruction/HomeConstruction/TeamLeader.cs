using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeConstruction
{
    public class TeamLeader : IWorker
    {
        public string Specialization { get; set; }
        public string FullName { get; set; }
        public TeamLeader(string spec, string fullname)
        {
            Specialization = spec;
            FullName = fullname;
        }
        public string CheckTheStage(House house)
        {
            if (house.Basement == null)
                return "basement";
            else if (house.Walls == null)
                return "walls";
            else if (house.Doors == null)
                return "door";
            else if (house.Windows == null)
                return "windows";
            else if (house.Roof == null)
                return "roof";
            return "done";
        }
        public void BuildPart(House house)
        {
            Console.WriteLine("\n Team Leader Report : Completed: ");
            if (CheckTheStage(house) == "basement")
            {
                Console.WriteLine("Nothing");
            }
            else if (CheckTheStage(house) == "walls")
            {
                Console.WriteLine("Basement");
            }
            else if (CheckTheStage(house) == "door")
            {
                Console.WriteLine(" Basement ,Walls");
            }
            else if (CheckTheStage(house) == "windows")
            {
                Console.WriteLine("Basement ,Walls,Door");
            }
            else if (CheckTheStage(house) == "roof")
            {
                Console.WriteLine("Basement ,Walls,Door,Windows");
            }
            else if (CheckTheStage(house) == "done")
            {
                Console.WriteLine("House is ready");
            }
        }
    }
}
