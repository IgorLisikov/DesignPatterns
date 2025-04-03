using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeSolution
{
    public class MonthlyReport : Report
    {
        public MonthlyReport(IReportFormat reportFormat) : base(reportFormat)
        {
        }

        public override void GetData()
        {
            Console.WriteLine("Getting monthly report data:");
        }
    }
}
