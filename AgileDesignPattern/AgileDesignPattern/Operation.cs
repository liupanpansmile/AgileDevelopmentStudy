using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileDesignPattern
{
    class Operation
    {
        public static void Copy(IReader reader, IWriter writer)
        {
            if (reader != null && writer != null)
            {
                string data = reader.Read();
                writer.Write(data);
            }
        }
    }
}
