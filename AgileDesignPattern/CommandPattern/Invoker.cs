using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class Invoker
    {
        private ICommand _displayCmd;
        private ICommand _redoCmd;
        private ICommand _undoCmd;

        public Invoker(ICommand displayCmd, ICommand redoCmd, ICommand undoCmd)
        {
            _displayCmd = displayCmd;
            _redoCmd = redoCmd;
            _undoCmd = undoCmd;
        }

        public void Display()
        {
           _displayCmd.Execute(); 
        }

        public void Undo()
        {
            _undoCmd.Execute();
        }

        public void Redo()
        {
            _redoCmd.Execute();
        }

    }
}
