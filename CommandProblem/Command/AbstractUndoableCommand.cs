using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Command
{
    public abstract class AbstractUndoableCommand : IUndoableCommand
    {
        protected History _history;
        protected VideoEditor _videoEditor;
        public AbstractUndoableCommand(History history, VideoEditor videoEditor)
        {
            _history = history;
            _videoEditor = videoEditor;
        }

        public void Execute()  // template method
        {
            DoExecute();
            _history.Push(this);
        }
        
        protected abstract void DoExecute();
        public abstract void Undo();
    }
}
