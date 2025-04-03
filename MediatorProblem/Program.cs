using MediatorProblem.Framework;
using MediatorProblem.SignUpForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            var userNameTextBox = new UserNameTextBox();
            var passwordTextBox = new PasswordTextBox();
            var signUpCheckBox = new SignUpCheckBox();
            var signUpButton = new SignUpButton();

            userNameTextBox.PasswordTextBox = passwordTextBox;
            userNameTextBox.SignUpCheckBox = signUpCheckBox;
            userNameTextBox.SignUpButton = signUpButton;

            passwordTextBox.UserNameTextBox = userNameTextBox;
            passwordTextBox.SignUpCheckBox = signUpCheckBox;
            passwordTextBox.SignUpButton = signUpButton;

            signUpCheckBox.UserNameTextBox = userNameTextBox;
            signUpCheckBox.PasswordTextBox = passwordTextBox;
            signUpCheckBox.SignUpButton = signUpButton;

            Console.WriteLine($"Button enabled: { signUpButton.IsEnabled()}");

            userNameTextBox.SetContent("UserName");
            userNameTextBox.Changed();
            Console.WriteLine($"Button enabled: { signUpButton.IsEnabled()}");

            passwordTextBox.SetContent("Password");
            passwordTextBox.Changed();
            Console.WriteLine($"Button enabled: { signUpButton.IsEnabled()}");

            signUpCheckBox.SetChecked(true);
            signUpCheckBox.Changed();
            Console.WriteLine($"Button enabled: { signUpButton.IsEnabled()}");

            signUpCheckBox.SetChecked(false);
            signUpCheckBox.Changed();
            Console.WriteLine($"Button enabled: { signUpButton.IsEnabled()}");
        }
    }
}
