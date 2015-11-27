using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileDesignPattern
{
    interface IReader
    {
        string Data { get; set; }
        string Read();
    }

    public class KeyBoarderReader : IReader
    {
        public string Data { get; set; }
        public string Read()
        {
            return Data;
        }
    }

}
