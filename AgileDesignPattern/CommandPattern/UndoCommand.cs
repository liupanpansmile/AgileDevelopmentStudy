using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class UndoCommand : ICommand
    {
        private Document _document;

        public UndoCommand(Document document)
        {
            _document = document;
        }

        public void Execute()
        {
            _document.Undo();
        }
    }
}
