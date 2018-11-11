using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XmlBase
{
    class Program
    {
        static void Main(string[] args)
        {
            Task2();
            Console.ReadLine();
        }
        private static void Task1()
        {
            List<Item> list = new List<Item>();
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load("habr.xml");
            var items = xmlDocument.DocumentElement.GetElementsByTagName("item");
            foreach (XmlElement item in items)
            {
                list.Add(new Item()
                {
                    Title = item.ChildNodes.Item(0).InnerText,
                    Link = item.ChildNodes.Item(1).InnerText,
                    Description = item.ChildNodes.Item(2).InnerText,
                    PubDate = item.ChildNodes.Item(3).InnerText,
                });
            }
            foreach (var item in list)
            {
                Console.Write( item.Title +"\n"+ item.Link + "\n" + item.Description + "\n" + item.PubDate);
            }
            Console.ReadLine();
        }
        private static void Task2()
        {
            XmlDocument xmlDocument = new XmlDocument();
            var students = xmlDocument.CreateElement("students");
            xmlDocument.AppendChild(students);
            var student = xmlDocument.CreateElement("student");
            student.SetAttribute("FirstName", "loolik");
            student.SetAttribute("LastName", "bolik");
            students.AppendChild(student);

            Console.WriteLine(xmlDocument.DocumentElement.FirstChild.Attributes["FirstName"].Value + " " + xmlDocument.DocumentElement.FirstChild.Attributes["LastName"].Value);
            Console.ReadLine();
        }
    }
}
