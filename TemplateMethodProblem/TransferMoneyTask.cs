using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodProblem
{
    public class TransferMoneyTask
    {
        private AuditTrail auditTrail;  // code repeat
        public TransferMoneyTask(AuditTrail auditTrail)
        {
            this.auditTrail = auditTrail;  // code repeat
        }

        public void Execute()
        {
            auditTrail.Record();  // code repeat

            Console.WriteLine("Transfer money");
        }
    }
}
