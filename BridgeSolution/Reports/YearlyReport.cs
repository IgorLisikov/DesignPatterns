using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeSolution
{
    public class YearlyReport : Report
    {
        public YearlyReport(IReportFormat reportFormat) : base(reportFormat)
        {
        }

        public override void GetData()
        {
            Console.WriteLine("Getting yearly report data:");
        }
    }
}
