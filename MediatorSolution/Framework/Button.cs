using MediatorSolution.SignUpForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorSolution.Framework
{
    public class Button : UIControl
    {
        private bool isEnabled;

        public Button(DialogBox owner) : base(owner)  // slight changes added to framework
        {

        }

        public bool IsEnabled()
        {
            return isEnabled;
        }

        public void SetEnabled(bool enabled)
        {
            isEnabled = enabled;
            owner.Changed(this);
        }
    }
}
