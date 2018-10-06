using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int c;
            char i;
            do
            {
                Console.WriteLine("Enter symbol");
                do
                {
                    c = Console.Read();
                    i = (char)c;
                } while (i == '\n' | i == '\r');



                if (c >= 65 && c <= 90)
                {
                    c += 32;
                    i = (char)c;
                    Console.WriteLine(i);
                   

                }
                else if (c >= 97 && c <= 122)
                {
                    c -= 32;
                    i = (char)c;
                    Console.WriteLine(i);
                   
                }
               
                else
                {
                    i = (char)c;
                    Console.WriteLine(i);
                }


            } while (true);
            
        }
    }
}
