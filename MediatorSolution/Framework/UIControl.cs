using MediatorSolution.SignUpForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorSolution.Framework
{
    public abstract class UIControl
    {
        protected DialogBox owner;   // slight changes added to framework

        public UIControl(DialogBox owner)   // slight changes added to framework
        {
            this.owner = owner;
        }
    }
}
