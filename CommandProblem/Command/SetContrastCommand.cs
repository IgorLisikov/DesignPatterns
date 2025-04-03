using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Command
{
    public class SetContrastCommand : AbstractUndoableCommand
    {
        private float _prevContrast;
        private float _contrast;

        public SetContrastCommand(float contrast, History history, VideoEditor videoEditor)
            : base(history, videoEditor)
        {
            _prevContrast = videoEditor.GetContrast();
            _contrast = contrast;
        }

        protected override void DoExecute()
        {
            _videoEditor.SetContrast(_contrast);
        }
        public override void Undo()
        {
            _videoEditor.SetContrast(_prevContrast);
        }
    }
}
