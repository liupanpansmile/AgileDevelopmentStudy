using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Strategy
{
    /// <summary>
    /// simulate shell sort
    /// </summary>
    public class ShellSort :ISortStrategy
    {
        public void Sort(List<string> list)
        {
            SortHelp(list);
        }

        private void SortHelp(List<string> list)
        {
            //shell sort
        }
    }
}
