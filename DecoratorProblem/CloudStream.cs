using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorProblem
{
    public class CloudStream
    {
        public void Write(string data)
        {
            Console.WriteLine("Storing " + data);
        }
    }
}
