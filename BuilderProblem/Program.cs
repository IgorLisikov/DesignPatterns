using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            var burger = new Burger(true, false, true, true, true);
            Console.WriteLine(burger);
        }
    }
}
