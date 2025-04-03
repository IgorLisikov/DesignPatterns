using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeVsAbstractFactory
{
    public class PrototypeFactory : AbstractFactory  // need only 1 factory class
    {
        private Window window;
        private Button button;

        public PrototypeFactory(Window window, Button button)
        {
            this.window = window;
            this.button = button;
        }

        public override Button CreateButton()
        {
            return button.Clone();
        }

        public override Window CreateWindow()
        {
            return window.Clone();
        }
    }
}
