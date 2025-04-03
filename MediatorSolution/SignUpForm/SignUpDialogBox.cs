using MediatorSolution.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorSolution.SignUpForm
{
    public class SignUpDialogBox : DialogBox   // SignUpDialogBox is a mediator for all UIControls
    {
        private TextBox userNameTextBox;
        private TextBox passwordTextBox;
        private CheckBox signUpCheckBox;
        private Button signUpButton;

        public SignUpDialogBox()
        {
            userNameTextBox = new TextBox(this);
            passwordTextBox = new TextBox(this);
            signUpCheckBox = new CheckBox(this);
            signUpButton = new Button(this);
        }

        public override void Changed(UIControl control)
        {
            if (control == userNameTextBox || control == passwordTextBox || control == signUpCheckBox)
            {
                if (!string.IsNullOrEmpty(userNameTextBox.GetContent()) &&
                    !string.IsNullOrEmpty(passwordTextBox.GetContent()) &&
                    signUpCheckBox.IsChecked())
                {
                    signUpButton.SetEnabled(true);
                }
                else
                {
                    signUpButton.SetEnabled(false);
                }
            }
        }
        public void SimulateInteraction()
        {
            userNameTextBox.SetContent("UserName1");
            Console.WriteLine($"UserName: {userNameTextBox.GetContent()}");
            Console.WriteLine($"Password: {passwordTextBox.GetContent()}");
            Console.WriteLine($"SignUp CheckBox checked?: {signUpCheckBox.IsChecked()}");
            Console.WriteLine($"Button enabled?: {signUpButton.IsEnabled()}");

            passwordTextBox.SetContent("Password1");
            signUpCheckBox.SetChecked(true);

            Console.WriteLine($"UserName: {userNameTextBox.GetContent()}");
            Console.WriteLine($"Password: {passwordTextBox.GetContent()}");
            Console.WriteLine($"SignUp CheckBox checked?: {signUpCheckBox.IsChecked()}");
            Console.WriteLine($"Button enabled?: {signUpButton.IsEnabled()}");

            signUpCheckBox.SetChecked(false);

            Console.WriteLine($"UserName: {userNameTextBox.GetContent()}");
            Console.WriteLine($"Password: {passwordTextBox.GetContent()}");
            Console.WriteLine($"SignUp CheckBox checked?: {signUpCheckBox.IsChecked()}");
            Console.WriteLine($"Button enabled?: {signUpButton.IsEnabled()}");
        }
    }
}
