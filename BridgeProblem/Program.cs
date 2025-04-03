using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            var report = new YearlyReportPdf();
            report.DoReport();

            // to add new type of report need to add 1 abstract + 2 concrete classes
            // if new type of report + new type of period are added -> 2 abstract + 3 concrete classes
        }
    }
}
