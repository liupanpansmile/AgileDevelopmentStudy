using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodTemplate
{
    class DoubleBubbleSorter : BubbleSorter
    {
        private double[] doubleArray;

        public DoubleBubbleSorter(double[] arr)
        {
            doubleArray = arr;
            length = arr.Length;
        }

        public override void Sort()
        {
            DoSort();
        }

        public override bool IsOrder(int index)
        {
            return (doubleArray[index] < doubleArray[index + 1]);
        }

        public override void Swap(int index)
        {
            double temp = doubleArray[index];
            doubleArray[index] = doubleArray[index + 1];
            doubleArray[index + 1] = temp;
        }
    }
}
