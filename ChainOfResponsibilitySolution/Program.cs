using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilitySolution
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader = DataReaderFactory.GetDataReaderChain();
            reader.Read("data.xls");
            reader.Read("data.numbers");
            reader.Read("data.qbw");
            reader.Read("data.jpg");
        }
    }
}
