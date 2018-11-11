using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public partial class Car
    {
        private string model;
        private double price;
        private int speed;
        private bool mechanic;
        private double mileage;

        public static bool warranty;
        public static int breakNum;

        public Car(string model, double price, int speed, bool mechanic, double mileage)
        {
            this.model = model;
            this.price = price;
            this.speed = speed;
            this.mechanic = mechanic;
            this.mileage = mileage;
        }
        public Car()
        {
             model = "classic";
            price =1;
            speed=1;
            mechanic=true;
            mileage=1;
        }
        public Car(string model, double price, int speed)
        {
            model = "Reno";
            price = 10000;
            speed = 200;
        }
        static Car()
        {
            warranty = true;
            breakNum = 4;
        }
        public void BreakIncrease(ref int breakNum)
        {
            breakNum = breakNum + 1;
        }
        public string Model { get; set; }
        public double Price { get; set; }
        public int Speed { get; set; }
        public bool Mechanic { get; set; }
        public double Mileage { get; set; }


    }
}
