using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeSolution
{
    public class WordReportFormat : IReportFormat
    {
        public void CloseFile()
        {
            Console.WriteLine("Closing word file:");
        }

        public void GenerateBody()
        {
            Console.WriteLine("Generating word report body:");
        }

        public void GenerateHeader()
        {
            Console.WriteLine("Generating word report header:");
        }

        public void OpenFile()
        {
            Console.WriteLine("Opening word file:");
        }
    }
}
