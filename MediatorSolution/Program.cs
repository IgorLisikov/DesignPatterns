using MediatorSolution.SignUpForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            var dialogBox = new SignUpDialogBox();
            dialogBox.SimulateInteraction();
        }
    }
}
