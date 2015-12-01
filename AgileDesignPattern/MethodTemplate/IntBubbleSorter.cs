using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodTemplate
{
    class IntBubbleSorter : BubbleSorter
    {
        private int[] intArray;

        public IntBubbleSorter(int[] arr)
        {
            intArray = arr;
            length = arr.Length;
        }

        public override void Sort()
        {
            DoSort();
        }

        public override bool IsOrder(int index)
        {
            return (intArray[index] < intArray[index + 1] );
        }

        public override void Swap(int index)
        {
            int temp = intArray[index];
            intArray[index] = intArray[index+1];
            intArray[index + 1] = temp;
        }
    }
}
