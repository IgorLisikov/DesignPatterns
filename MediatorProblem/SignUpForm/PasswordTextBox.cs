using MediatorProblem.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorProblem.SignUpForm
{
    public class PasswordTextBox : TextBox  // need to add inherited classes like PasswordTextBox, etc.
    {
        public Button SignUpButton { get; set; }  // need to add a lot of dependencies
        public TextBox UserNameTextBox { get; set; }
        public CheckBox SignUpCheckBox { get; set; }

        public void Changed()
        {
            if (!string.IsNullOrWhiteSpace(GetContent()) && !string.IsNullOrWhiteSpace(UserNameTextBox.GetContent()) && SignUpCheckBox.IsChecked())
            {
                SignUpButton.SetEnabled(true);
            }
            else
            {
                SignUpButton.SetEnabled(false);
            }
        }
    }
}
