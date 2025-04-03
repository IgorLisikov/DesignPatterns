using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeProblem
{
    public abstract class ReportWord : Report
    {
        public override void CloseFile()
        {
            Console.WriteLine("Closing word file:");
        }

        public override void GenerateBody()
        {
            Console.WriteLine("Generating word report body:");
        }

        public override void GenerateHeader()
        {
            Console.WriteLine("Generating word report header:");
        }

        public override void OpenFile()
        {
            Console.WriteLine("Opening word file:");
        }
    }
}
