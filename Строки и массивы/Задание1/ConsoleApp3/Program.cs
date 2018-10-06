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
            char symbol;
            int spaceNum = 0;
           
            
            do
            {
                Console.WriteLine("Enter symbol | Press Enter | Enter point to stop:");
                symbol = (char)Console.Read();
                if (symbol == ' ')
                {
                    spaceNum++;
                }
                else if (symbol == '.')
                {
                    break;
                }
                Console.Clear();
            } while (true);
            Console.WriteLine("Space number:"+spaceNum);
            Console.ReadKey();

        }
    }
}
