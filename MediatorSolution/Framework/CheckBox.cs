using MediatorSolution.SignUpForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorSolution.Framework
{
    public class CheckBox : UIControl
    {
        private bool isChecked;

        public CheckBox(DialogBox owner) : base(owner)  // slight changes added to framework
        {

        }

        public bool IsChecked()
        {
            return isChecked;
        }

        public void SetChecked(bool status)
        {
            isChecked = status;
            owner.Changed(this);
        }
    }
}
