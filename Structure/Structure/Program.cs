using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Console.ReadLine();
        }
        private static void Task1()
        {
            int personCount = 0, avgSalary = 0;
            Console.WriteLine("Enter workers num");
            personCount = Convert.ToInt32(Console.ReadLine());

            List <Person> people = new List<Person> (personCount);
            for (int i = 0; i < personCount; i++)
            {
                Console.WriteLine("Enter First Name ,Last name and salary");
                people.Add( new Person()
                {
                    FirstName = Console.ReadLine(),
                    LastName = Console.ReadLine(),
                    Salary = Convert.ToInt32(Console.ReadLine()),
                    Post = Console.ReadLine(),
                    Acceptance = DateTime.Parse(Console.ReadLine())
            });
                avgSalary += people[i].Salary;
            }
            avgSalary /= personCount;
            
            foreach (var person in people)
            {
                Console.WriteLine(" First name:" + person.FirstName);
                Console.WriteLine(" Last name:" + person.LastName);
                Console.WriteLine(" Salary:" + person.Salary);
                Console.WriteLine(" Post:" + person.Post);
                Console.WriteLine(" Acceptance:" + person.Acceptance);
            }

            Console.WriteLine("Managers with salsry higher than average");
            Console.WriteLine("Average Salary = " + avgSalary);

            foreach (var person in people)
            {
                if (person.Salary > avgSalary)
                {
                    Console.WriteLine(" First name:" + person.FirstName);
                    Console.WriteLine(" Last name:" + person.LastName);
                    Console.WriteLine(" Salary:" + person.Salary);
                    Console.WriteLine(" Post:" + person.Post);
                    Console.WriteLine(" Acceptance:" + person.Acceptance);
                }
            }
            Console.WriteLine();
            int director=0;
            for (int i = 0; i < personCount; i++)
            {
                if (people[i].Post=="Boss")
                {
                    director = i;
                }
            }
            for (int i = 0; i < personCount; i++)
            {
                if (people[i].Acceptance < people[director].Acceptance)
                {
                    Console.WriteLine(" First name:" + people[i].FirstName);
                    Console.WriteLine(" Last name:" + people[i].LastName);
                    Console.WriteLine(" Salary:" + people[i].Salary);
                    Console.WriteLine(" Post:" + people[i].Post);
                    Console.WriteLine(" Acceptance:" + people[i].Acceptance);
                }
            }

            

        }
        private static void Task2()
        {
            const int minSalary = 5000;
            int studentCount = 0;
            Console.WriteLine("Enter student num");
            studentCount = Convert.ToInt32(Console.ReadLine());

            List<Student> students = new List<Student>(studentCount);
           
            Console.WriteLine();
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("Enter First Name ,Last name and salary");
                students.Add(new Student()
                {
                    AvgValue = Convert.ToInt32(Console.ReadLine()),
                    FirstName = Console.ReadLine(),
                    LastName = Console.ReadLine(),
                    Sex = (Sex)Convert.ToInt32(Console.ReadLine()),
                    EduType = (EduType)Convert.ToInt32(Console.ReadLine()),
                    Profit = Convert.ToInt32(Console.ReadLine())
                });
            }
            foreach (var student in students)
            {
                if (student.Profit < minSalary * 2)
                {
                    Console.WriteLine(" First name:" + student.FirstName);
                    Console.WriteLine(" Last name:" + student.LastName);
                    Console.WriteLine(" Salary:" + student.Profit);
                    Console.WriteLine(" GroupName:" + student.GroupName);
                    Console.WriteLine(" AvgValue:" + student.AvgValue);
                    Console.WriteLine(" Sex:" + student.Sex);
                    Console.WriteLine(" EduType:" + student.EduType);
                }
            }
            Console.WriteLine();
            foreach (var student in students.OrderByDescending(student => student.AvgValue).Where(student => !(student.Profit < minSalary * 2)))
            {
                Console.WriteLine(" First name:" + student.FirstName);
                Console.WriteLine(" Last name:" + student.LastName);
                Console.WriteLine(" AvgValue:" + student.AvgValue);
            }
            Console.ReadLine();
        }

    }
}
