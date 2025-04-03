using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilitySolution
{
    public class NumbersReader : DataReader
    {
        protected override void DoRead(string fileName)
        {
            Console.WriteLine("Reading data from a Numbers spreadsheet: ");
        }

        protected override string GetExtension()
        {
            return ".numbers";
        }
    }
}
