using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.Src
{
    public interface IAgent
    {
        void Start();
        void Connect();
        void ShutDown();

    }
}
