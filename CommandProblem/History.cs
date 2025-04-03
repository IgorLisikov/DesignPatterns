using Command.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class History
    {
        private IList<IUndoableCommand> _commands;

        public History()
        {
            _commands = new List<IUndoableCommand>();
        }

        public void Push(IUndoableCommand command)
        {
            _commands.Add(command);
        }
        public IUndoableCommand Pop()
        {
            int lastIndex = _commands.Count - 1;
            var lastCommand = _commands[lastIndex];
            _commands.Remove(lastCommand);

            return lastCommand;
        }
        public int GetSize()
        {
            return _commands.Count();
        }
    }
}
