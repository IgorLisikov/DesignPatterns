using MediatorSolutionWithObserver.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorSolutionWithObserver.SignUpForm
{
    public class SignUpDialogBox : IObserver
    {
        private TextBox userNameTextBox;
        private TextBox passwordTextBox;
        private CheckBox signUpCheckBox;
        private Button signUpButton;

        public SignUpDialogBox()
        {
            userNameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            signUpCheckBox = new CheckBox();
            signUpButton = new Button();

            userNameTextBox.AddObserver(this);
            passwordTextBox.AddObserver(this);
            signUpCheckBox.AddObserver(this);
            // signUpButton.AddObserver(this);   button is not observed, othervise Update() method gets into endless loop
        }

        public void Update()
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
