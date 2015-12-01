using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    /// <summary>
    /// Sort Strategy abstract
    /// </summary>
    interface ISortStrategy
    {
        void Sort(List<string> list);
    }
}
