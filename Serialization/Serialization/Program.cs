using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task1();
            Task2();
            Console.ReadLine();
        }
        private static void Task1()
        {
            List<Book> list = new List<Book>()
            {
                new Book()
                {
                    Name="Legacy",
                    Author="Morgn",
                    Price=200000,
                    PublishYear=2022
                },
                new Book()
                {
                    Name="Legacy",
                    Author="Morgn",
                    Price=200000,
                    PublishYear=2022
                }

            };
            using (FileStream file1 = new FileStream("OUTPUT.txt", FileMode.OpenOrCreate))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(file1, list);
            }

        }
        private static void Task2()
        {
            using (FileStream fs = new FileStream("output.txt", FileMode.OpenOrCreate))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                var books = binaryFormatter.Deserialize(fs) as List<Book>;
                foreach (var book in books)
                {
                    Console.WriteLine(book.Price);
                }
                Console.WriteLine();
            }
        }
    }
}
