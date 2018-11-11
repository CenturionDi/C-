using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 3,4,1,2,7,9,3,4,5};
            int max = 0,max2=0,sum=0;
            for (int i = 1; i < list.Count; i++)
            {
                Console.Write(list[i]);
            }
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] > list[max])
                {
                    max = i;
                }
            }

            for (int i = 1; i < list.Count; i++)
            {
                if ((list[i] > list[max2])&&(i != max) && (list[i] != list[max]) )
                {
                    max2 = i;
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (i % 2 == 0)
                    sum += list[i];
            }

            Console.WriteLine("\nSumm of elements on even positions:" + sum+ "\nSecond max element position: "+max2+ "\nSecond max element: " + list[max2]  );

            

            Console.ReadLine();
        }
    }
}
