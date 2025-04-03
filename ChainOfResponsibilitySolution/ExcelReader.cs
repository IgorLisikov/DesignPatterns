using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilitySolution
{
    public class ExcelReader : DataReader
    {
        protected override void DoRead(string fileName)
        {
            Console.WriteLine("Reading data from an Excel spreadsheet.");
        }

        protected override string GetExtension()
        {
            return ".xls";
        }
    }
}
