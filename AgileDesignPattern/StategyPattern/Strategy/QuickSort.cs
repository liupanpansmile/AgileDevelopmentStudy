using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Strategy
{
    /// <summary>
    /// Quick Sort
    /// </summary>
    class QuickSort :ISortStrategy
    {
        public void Sort(List<string> list)
        {
           // throw new NotImplementedException();
           list.Sort();
        }
    }
}
