using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            Task2();
            Console.ReadLine();
        }
        private static void Task1()
        {
            using (StreamReader stream = new StreamReader("Fib.txt"))
            {
                string str = stream.ReadLine();
                var numbers = str.Split(' ').ToList();
                int count = numbers.Count;
                for (int i = 0; i < count; i++)
                {
                    int num = int.Parse(numbers[numbers.Count - 2]) + int.Parse(numbers[numbers.Count - 1]);
                    numbers.Add(num.ToString());
                }
                foreach (var num in numbers)
                {
                    Console.Write(" "+ num);
                }

            }
        }
        private static void Task2()
        {
            using (StreamReader stream = new StreamReader("INPUT.txt"))
            {
                string str = stream.ReadLine();
                var numbers = str.Split(' ');
                int sum = 0;
                foreach (var num in numbers)
                {
                    sum += int.Parse(num);
                }
                using (StreamWriter streamWriter = new StreamWriter("OUTPUT.txt"))
                {
                    Console.Write("Sum: " + sum);
                    streamWriter.WriteLine(sum);
                }
            }
        }
    }
}
