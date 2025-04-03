using Command.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var videoEditor = new VideoEditor();
            var history = new History();

            var setTextCommand = new SetTextCommand("Video Title", history, videoEditor);
            setTextCommand.Execute();
            Console.WriteLine("TEXT: " + videoEditor);

            setTextCommand = new SetTextCommand("Video Title 25", history, videoEditor);
            setTextCommand.Execute();
            Console.WriteLine("TEXT: " + videoEditor);

            var setContrast = new SetContrastCommand(1, history, videoEditor);
            setContrast.Execute();
            Console.WriteLine("CONTRAST: " + videoEditor);

            var undoCommand = new UndoCommand(history);
            undoCommand.Execute();
            Console.WriteLine("UNDO: " + videoEditor);

            undoCommand.Execute();
            Console.WriteLine("UNDO: " + videoEditor);

            undoCommand.Execute();
            Console.WriteLine("UNDO: " + videoEditor);

            undoCommand.Execute();
            Console.WriteLine("UNDO: " + videoEditor);
        }
    }
}
