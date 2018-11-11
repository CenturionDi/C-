using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeConstruction
{
    public class Worker : IWorker
    {
        public string Specialization { get; set; }
        public string FullName { get; set; }
        public Worker(string spec , string fullname)
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
            Console.WriteLine("\nCompleted: ");
            if (CheckTheStage(house) == "basement")
            {
                Console.Write(CheckTheStage(house));
                house.Basement = new Basement("Rock",2,3,4);
            }
            else if (CheckTheStage(house) == "walls")
            {
                Console.Write(CheckTheStage(house));
                house.Walls = new List<Walls>();
                house.Walls.Add(new Walls("Wood", 2, 3, 4));
                house.Walls.Add(new Walls("Wood", 2, 3, 4));
                house.Walls.Add(new Walls("Wood", 2, 3, 4));
                house.Walls.Add(new Walls("Wood", 2, 3, 4));
            }
            else if (CheckTheStage(house) == "door")
            {
                Console.Write(CheckTheStage(house));
                house.Doors = new List<Door>();
                house.Doors.Add(new Door("Dark Wood", 2, 1, 1));
                house.Doors.Add(new Door("Dark Wood", 2, 1, 1));
                house.Doors.Add(new Door("Dark Wood", 2, 1, 1));
                house.Doors.Add(new Door("Dark Wood", 2, 1, 1));
            }
            else if (CheckTheStage(house) == "windows")
            {
                Console.Write(CheckTheStage(house));
                house.Windows = new List<Window>();
                house.Windows.Add(new Window("Light Wood", 2, 2, 2));
                house.Windows.Add(new Window("Light Wood", 2, 2, 2));
                house.Windows.Add(new Window("Light Wood", 2, 2, 2));
                house.Windows.Add(new Window("Light Wood", 2, 2, 2));
            }
            else if (CheckTheStage(house) == "roof")
            {
                Console.Write(CheckTheStage(house));
                house.Basement = new Basement("Tile", 2, 3, 4);
                Console.WriteLine("\n^----^^--^^");
                Console.WriteLine(  "|* * {} * *|");
                Console.WriteLine(  "___________");
            }
            else if (CheckTheStage(house) == "done")
            {
                Console.WriteLine("^");
                Console.WriteLine("||");
                Console.WriteLine("_");
            }
        }
    }
}
