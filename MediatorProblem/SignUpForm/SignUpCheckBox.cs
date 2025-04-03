using MediatorProblem.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorProblem.SignUpForm
{
    public class SignUpCheckBox : CheckBox
    {
        public Button SignUpButton { get; set; }
        public TextBox UserNameTextBox { get; set; }
        public TextBox PasswordTextBox { get; set; }

        public void Changed()
        {
            if (IsChecked() && !string.IsNullOrWhiteSpace(UserNameTextBox.GetContent()) && !string.IsNullOrWhiteSpace(PasswordTextBox.GetContent()))
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
