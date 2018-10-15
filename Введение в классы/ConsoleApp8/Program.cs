using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Car one = new Car();
            Car two = new Car();
            Car three = new Car();
            Car four = new Car();
            Car five = new Car();
            List<Car> cars = new List<Car>();
            cars.Add(one);
            cars.Add(two);
            cars.Add(three);
            cars.Add(four);
            cars.Add(five);
        }
    }
}
