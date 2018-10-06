using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 6 digit number: ");
            string text = "111111";
            text = Console.ReadLine();
            string sym1;
            string sym2;
            string sym3;
            string sym4;
            string sym5;
            string sym6;

            sym1 = text.Substring(0, text.Length - 5);
            sym2 = text.Substring(1, text.Length - 5);
            sym3 = text.Substring(2, text.Length - 5);
            sym4 = text.Substring(3, text.Length - 5);
            sym5 = text.Substring(4, text.Length - 5);
            sym6 = text.Substring(5, text.Length - 5);

           
            if ((sym1+sym2+sym3)== (sym4 + sym5 + sym6))
            {
                Console.WriteLine("Lucky ticket!");
            }
            else
            {
                Console.WriteLine("Simple ticket(");
            }
            Console.ReadKey();
        }
    }
}
