using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeVsAbstractFactory
{
    public abstract class AbstractFactory // creates groups of products
    {
        public abstract Window CreateWindow();
        public abstract Button CreateButton();
    }
}
