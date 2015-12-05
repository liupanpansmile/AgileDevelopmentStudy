using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.Src
{
    public class Agent : IAgent
    {
        private static readonly Singleton _singleton = new Singleton();
        private Agent()
        {

        }

        public static IAgent Instance
        {
            get
            {
                return _singleton.CreateInstance();
            }
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

        internal class Singleton
        {
            private static IAgent _agent;
            public IAgent CreateInstance()
            {
                return _agent ?? (_agent = new Agent());
            }
        }
    }
}
