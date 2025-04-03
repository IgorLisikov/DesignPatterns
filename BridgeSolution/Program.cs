using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            var report = new YearlyReport(new PdfReportFormat());
            report.DoReport();

            // to add new type of report need to add 1 class
            // if new type of report + new type of period are added -> 2 new classes
        }
    }
}
