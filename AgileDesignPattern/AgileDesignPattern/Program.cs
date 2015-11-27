using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IReader reader = new KeyBoarderReader() {Data = "OneAPM"} ;
            IWriter writer = new PrinterWriter();
            Operation.Copy(reader,writer);
        }


    }
}
