using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void one()
        {
            int first = 2, second = 3, third = 4;
            Console.WriteLine($"{first}  {second}  {third}");
        }
        static void two()
        {
            int first = 5, second = 10, third = 21;
            Console.WriteLine($"{first}\n{second}\n{third}");
        }
        static void three()
        {
            Console.Write("Enter in cm: ");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Metres:{length / 100}");
        }
        static void four()
        {
            int length = 234;
            Console.WriteLine($"Weeks:{length / 7}");
        }
        static void five()
        {

            int num = 27;
            int decima = num / 10;
            int unit = num - (decima * 10);
            Console.WriteLine($"Num:{num} Tenths:{decima} Units:{unit} Sum:{unit + decima} Multiplication:{unit * decima}");

        }
        static void six()
        {
            bool a = true, b = false, c = false;
            Console.WriteLine($"A or B:{a || b} A and B:{ a && b} B or C:{b || c} ");
        }
        static void seven()
        {
            Console.Write("Enter circle radius: ");
            double rad = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter square side: ");
            double side = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Circle area:{Math.PI * rad * rad} Square area:{side * side}");
            Console.Write(((Math.PI * rad * rad) > (side * side)) ? "Circle area greater" : "Square area greater");

        }
        static void eight()
        {
            Console.Write("Enter first mass: ");
            double mass1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter first volume: ");
            double volume1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second mass: ");
            double mass2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second volume: ");
            double volume2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"First density:{mass1 / volume1} Second density:{mass2 / volume2}");
            Console.Write(((mass1 / volume1) > (mass2 / volume2)) ? "Circle area greater" : "Square area greater");

        }
        static void nine()
        {
            Console.Write("Enter first resistance: ");
            double res1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter first voltage: ");
            double vol1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second resistance: ");
            double res2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second voltage: ");
            double vol2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"First current:{vol1 / res1} Second current:{vol2 / res2}");
            Console.Write(((vol1 / res1) < (vol2 / res2)) ? "First current is less" : "Second current is less");

        }
        static void ten()
        {
            Console.WriteLine("task 1");
            for (int i = 20; i < 35; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("task 2");
            Console.WriteLine("Enter value bigger than 10: ");
            int b = Convert.ToInt32(Console.ReadLine());
            for (int i = 10; i < b; i++)
            {
                Console.WriteLine("{0} Sq = {1}", i, Math.Pow(i, 2));
            }
            Console.WriteLine("task3");

            Console.Write("Enter value bigger than 50: ");
            int ñ = Convert.ToInt32(Console.ReadLine());
            for (int i = 50; i < ñ; i++)
            {
                Console.WriteLine("{0} Cub = {1}", i, Math.Pow(i, 3));
            }
            Console.WriteLine("task4");
            Console.Write("Enter first value: ");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second value: ");
            int second = Convert.ToInt32(Console.ReadLine());

            for (int i = first; i < second; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            seven();
            Console.Write("\nPress any key to exit...");
            Console.ReadKey(true);

        }
    }
}