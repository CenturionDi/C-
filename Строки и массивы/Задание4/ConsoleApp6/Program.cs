using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
                int a, b;
                Console.WriteLine("Введите А");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите B");
                b = Convert.ToInt32(Console.ReadLine());
            if ((a>0) && (b>0) && (b>a) )
            {
                Console.Clear();
                for (int i = a; i <= b; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(i);
                    }
                    Console.WriteLine();
                }
            }
            else 
            {
                Console.WriteLine("Error: a should be bigger than b || a and b - positive numbers");
            }
            
               
            Console.ReadKey();
            
        }
    }
}
