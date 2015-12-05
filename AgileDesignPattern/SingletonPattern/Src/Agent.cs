using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.Src
{
    public class Agent : IAgent
    {
        private static IAgent _agent;

        private Agent()
        {

        }
        public static IAgent CreateInstance()
        {
            if (null == _agent)
            {
                _agent = new Agent();
            }
            return _agent;
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Connect()
        {
            throw new NotImplementedException();
        }

        public void ShutDown()
        {
            throw new NotImplementedException();
        }
    }
}
