using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeProblem
{
    public class MonthlyReportPdf : ReportPdf
    {
        public override void GetData()
        {
            Console.WriteLine("Getting monthly report data:");
        }
    }
}
