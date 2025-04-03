using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeVsAbstractFactory
{
    public abstract class Window
    {
        public Window Clone()
        {
            return (Window)this.MemberwiseClone();
        }
    }
}
