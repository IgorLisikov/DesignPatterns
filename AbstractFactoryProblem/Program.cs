using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryProblem
{
    class Program
    {
        static void Main(string[] args)   // concrete instances are defined in many places
        {
            var isWindows = true;
            Window window;
            Button button;

            if (isWindows)
            {
                window = new WinWindow();
                button = new WinButton();
            }
            else
            {
                window = new MacWindow();
                button = new MacButton();
            }
        }
    }
}
