using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactorySolution
{
    public class MacFactory : AbstractFactory
    {
        public override Button CreateButton()
        {
            return new MacButton();
        }

        public override Window CreateWindow()
        {
            return new MacWindow();
        }
    }
}
