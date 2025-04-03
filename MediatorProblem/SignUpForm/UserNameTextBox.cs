using MediatorProblem.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorProblem.SignUpForm
{
    public class UserNameTextBox : TextBox
    {
        public Button SignUpButton { get; set; }
        public TextBox PasswordTextBox { get; set; }
        public CheckBox SignUpCheckBox { get; set; }

        public void Changed()
        {
            if (!string.IsNullOrWhiteSpace(GetContent()) && !string.IsNullOrWhiteSpace(PasswordTextBox.GetContent()) && SignUpCheckBox.IsChecked())
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
