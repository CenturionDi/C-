using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Array
    {
        private int[] array;
        public int Size { get; set; }

        public Array()
        {

            Size = 1;
            array = new int[Size];
        }

        public Array(int size)
        {

            Size = size;
            array = new int[Size];
        }
        public int this[int index]
        {
            get { return array[index]; }
            set { array[index] = (int)Math.Pow((double)value, 2); }
        }

     



    }
}
