using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StategyPattern.Strategy;

namespace StategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList list = new SortedList();
            list.Add("Jack");
            list.Add("Marry");
            list.Add("Lucy");
            list.Add("Amber");

            list.SetSortStrategy(new QuickSort());
            list.Sort();
            list.ShowInfo();

            list.SetSortStrategy(new ShellSort());
            list.Sort();
            list.ShowInfo();


        }
    }
}
