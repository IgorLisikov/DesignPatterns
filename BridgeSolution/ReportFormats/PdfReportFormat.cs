using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeSolution
{
    public class PdfReportFormat : IReportFormat
    {
        public void CloseFile()
        {
            Console.WriteLine("Closing pdf file:");
        }

        public void GenerateBody()
        {
            Console.WriteLine("Generating pdf report body:");
        }

        public void GenerateHeader()
        {
            Console.WriteLine("Generating pdf report header:");
        }

        public void OpenFile()
        {
            Console.WriteLine("Opening pdf file:");
        }
    }
}
