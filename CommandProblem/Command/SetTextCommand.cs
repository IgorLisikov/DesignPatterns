using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Command
{
    public class SetTextCommand : AbstractUndoableCommand
    {
        private string _prevText;
        private string _text;

        public SetTextCommand(string text, History history, VideoEditor videoEditor)
            : base(history, videoEditor)
        {
            _prevText = videoEditor.GetText();
            _text = text;
        }

        protected override void DoExecute()
        {
            _videoEditor.SetText(_text);
        }
        public override void Undo()
        {
            _videoEditor.SetText(_prevText);
        }
    }
}
