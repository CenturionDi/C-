using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static string Revers(string str)
        {
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            return new String(arr);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            string str2 = Console.ReadLine();
            int i = Convert.ToInt32(Revers(str2));
            Console.WriteLine("reversed number");
            Console.WriteLine( i );
            Console.ReadKey();
        }
    }
}
