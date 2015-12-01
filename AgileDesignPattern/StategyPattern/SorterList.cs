using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class SortedList
    {
        private List<string> _list = new List<string>();
        private ISortStrategy _sortStrategy;

        public SortedList()
        {
            
        }

        public void SetSortStrategy(ISortStrategy strategy)
        {
            _sortStrategy = strategy;
        }

        public void Sort()
        {
            _sortStrategy.Sort(_list);
        }
        public void Add(string element)
        {
            _list.Add(element);
        }

        public void ShowInfo()
        {
            foreach (var element in _list)
            {
                Console.WriteLine(element);
            }
        }

    }
}
