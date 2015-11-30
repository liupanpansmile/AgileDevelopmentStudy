using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class RedoCommand : ICommand
    {
        private Document _document;

        public RedoCommand(Document document)
        {
            _document = document;
        }

        public void Execute()
        {
            _document.Redo();
        }
    }
}
