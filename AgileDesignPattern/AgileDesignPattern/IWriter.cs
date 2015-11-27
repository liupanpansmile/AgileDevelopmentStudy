using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileDesignPattern
{
    /* output device interface */
    interface IWriter
    {
        void Write(string data);
    }


    /*printer*/
    public class PrinterWriter:IWriter
    {
        public void Write(string data)
        {
            Console.WriteLine("simulate Printer: {0}",data);
        }
    }
}
