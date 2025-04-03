using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactorySolution
{
    public class WinFactory : AbstractFactory
    {
        public override Button CreateButton()
        {
            return new WinButton();
        }

        public override Window CreateWindow()
        {
            return new WinWindow();
        }
    }
}
