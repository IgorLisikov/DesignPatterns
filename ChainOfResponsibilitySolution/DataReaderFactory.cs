using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilitySolution
{
    public class DataReaderFactory
    {
        public static DataReader GetDataReaderChain()
        {
            var exclreader = new ExcelReader();
            var numbersReader = new NumbersReader();
            var quickBooksReader = new QuickBooksReader();

            quickBooksReader.SetNext(numbersReader);
            numbersReader.SetNext(exclreader);

            return quickBooksReader;
        }
    }
}
