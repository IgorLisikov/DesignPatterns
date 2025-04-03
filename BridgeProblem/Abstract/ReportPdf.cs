using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeProblem
{
    public abstract class ReportPdf : Report
    {
        public override void CloseFile()
        {
            Console.WriteLine("Closing pdf file:");
        }

        public override void GenerateBody()
        {
            Console.WriteLine("Generating pdf report body:");
        }

        public override void GenerateHeader()
        {
            Console.WriteLine("Generating pdf report header:");
        }

        public override void OpenFile()
        {
            Console.WriteLine("Opening pdf file:");
        }
    }
}
