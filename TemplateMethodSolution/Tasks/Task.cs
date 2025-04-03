using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodSolution.Tasks
{
    public abstract class Task
    {
        private AuditTrail auditTrail;   // no code repeat
        public Task(AuditTrail auditTrail)
        {
            this.auditTrail = auditTrail;  // no code repeat
        }

        public void Execute()  // this is template method
        {
            auditTrail.Record();  // no code repeat

            DoExecute();
        }

        protected abstract void DoExecute();  // protected, to restrict direct call that skips auditTrail.Record() and violates the template
    }
}
