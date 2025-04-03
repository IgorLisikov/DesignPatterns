using MediatorSolution.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorSolution.Framework
{
    public abstract class DialogBox  // slight changes added to framework
    {
        public abstract void Changed(UIControl control);
    }
}
