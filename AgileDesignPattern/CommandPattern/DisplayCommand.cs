using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class DisplayCommand : ICommand
    {
        private Document _document;

        public DisplayCommand(Document document)
        {
            _document = document;
        }

        public void Execute()
        {
            _document.Display();
        }
    }
}
