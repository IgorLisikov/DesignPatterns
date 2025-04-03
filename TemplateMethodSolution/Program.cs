using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethodSolution.Tasks;

namespace TemplateMethodSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            var auditTrail = new AuditTrail();

            var task = new TransferMoneyTask(auditTrail);
            task.Execute();

            Console.WriteLine();

            var task2 = new GenerateReportTask(auditTrail);
            task2.Execute();
        }
    }
}
