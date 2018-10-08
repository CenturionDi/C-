using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Array array = new Array(2);
            Console.WriteLine("Enter value for first");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for second");
            int b = Convert.ToInt32(Console.ReadLine());
            array[0] = a;
            array[1] = b;
           
            for (int i = 0; i < array.Size; i++)
            {
                Console.WriteLine("Element: "+i);
                Console.Write(array[i]);
                Console.WriteLine(" ");
            }
            Console.WriteLine();
            Console.ReadKey();


        }
    }
}
