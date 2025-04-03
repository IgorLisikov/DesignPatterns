using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodSolution.Tasks
{
    public class GenerateReportTask : Task
    {
        public GenerateReportTask(AuditTrail auditTrail) : base(auditTrail)
        {
        }

        protected override void DoExecute()
        {
            Console.WriteLine("Generate report");
        }
    }
}
