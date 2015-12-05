using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Document document = new Document();
            ICommand displayCmd = new DisplayCommand(document);
            ICommand redoCmd = new RedoCommand(document);
            ICommand undoCmd = new UndoCommand(document);

            Invoker invoker = new Invoker(displayCmd, redoCmd, undoCmd);
            invoker.Display();
            invoker.Redo();
            invoker.Undo();

        }
    }
}
