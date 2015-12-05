using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonostatePattern.Source
{
    public class Monostate
    {
        private static int _itsX = 0;

        public int ItsX
        {
            get
            {
                return _itsX;
                
            }
            set
            {
                _itsX = value;
            }
        }

        public Monostate(int value = 0)
        {
            ItsX = value;
        }
    }
}
