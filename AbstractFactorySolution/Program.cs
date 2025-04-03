using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactorySolution
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory factory = new WinFactory();   // concrete instance is defined in single place 
            Window window = factory.CreateWindow();
            Button button = factory.CreateButton();
        }
    }
}
