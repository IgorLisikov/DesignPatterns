using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilitySolution
{
    public class QuickBooksReader : DataReader
    {
        protected override void DoRead(string fileName)
        {
            Console.WriteLine("Reading data from a QuickBooks file.");
        }

        protected override string GetExtension()
        {
            return ".qbw";
        }
    }
}
