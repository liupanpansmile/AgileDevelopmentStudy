using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class Document
    {
        public void Display()
        {
            Console.WriteLine("Display Document");
        }

        public void Undo()
        {
            Console.WriteLine("Undo Document");
        }

        public void Redo()
        {
            Console.WriteLine("Redo Document");
        }
    }
}
