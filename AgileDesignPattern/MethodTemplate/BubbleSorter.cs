using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodTemplate
{
    abstract class BubbleSorter
    {
        protected int length;
        public abstract void Sort();
        public abstract bool IsOrder(int index);
        public abstract void Swap(int index);

        public void DoSort()
        {
            for (int i = 0; i < length - 1; ++i)
            {
                for (int j = 0; j < length - 1 - i; ++j)
                {
                    if (!IsOrder(j))
                    {
                        Swap(j);
                    }
                }
            }
        }
    }
}
