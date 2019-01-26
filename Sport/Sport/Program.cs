using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams;
            using (var context = new SportContext())
            {
                teams = context.Teams.ToList();
                context.Entry(teams[0]).Collection("Players").Load();
                teams = context.Teams.Include("Players").ToList();
                var stub = teams[0].Players;
                //var team = new Team
                //{
                //    Name = "Telepyziki"
                //};
                //var playerOne = new Player
                //{
                //    FullName = "Kobzon",
                //    Number = 7
                //};
                //var playerTwo = new Player
                //{
                //    FullName = "Stas",
                //    Number = 2
                //};
                //team.Players = new List<Player>
                //{
                //    playerOne,playerTwo
                //};
                //context.Players.Add(playerOne);
                //context.Players.Add(playerTwo);
                //context.Teams.Add(team);
                //context.SaveChanges();
                Console.WriteLine("Enter player name");
                string name = Console.ReadLine();
                var players = context.Players.Where(p => p.FullName == name);
                foreach (Player p in players)
                    Console.WriteLine("{0}.{1} - {2}", p.Id, p.FullName, p.Number);
            }
           
        }
    }
}
