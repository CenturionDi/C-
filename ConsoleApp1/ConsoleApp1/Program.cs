using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var date = DateTime.Now;
            Console.WriteLine($"Date: {date:d} Time:{date:t}!");
            Console.WriteLine("\nHello world! I was born! ");
            Console.Write("\nPress any key to exit...");
            Console.ReadKey(true);

        }
    }
}
