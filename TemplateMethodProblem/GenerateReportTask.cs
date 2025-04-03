using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodProblem
{
    public class GenerateReportTask
    {
        private AuditTrail auditTrail;  // code repeat
        public GenerateReportTask(AuditTrail auditTrail)
        {
            this.auditTrail = auditTrail;  // code repeat
        }

        public void Execute()
        {
            auditTrail.Record();  // code repeat

            Console.WriteLine("Generate report");
        }
    }
}
