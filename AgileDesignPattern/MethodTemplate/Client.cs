using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodTemplate
{
    class Client
    {
        public static void Print<T>(T[] arr)
        {
            foreach (var element in arr)
            {
                Console.Write("{0} ",element);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] intArr = {3, 5, 1, 4, 2};
            double[] doubleArr = {3.0, 5.0, 1.0, 4.0, 2.0};

            BubbleSorter intSorter = new IntBubbleSorter(intArr);
            BubbleSorter doubleSorter = new DoubleBubbleSorter(doubleArr);
            intSorter.Sort();
            doubleSorter.Sort();

            Print(intArr);
            Print(doubleArr);
        }
    }
}
