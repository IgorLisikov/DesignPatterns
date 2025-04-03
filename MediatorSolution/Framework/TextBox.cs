using MediatorSolution.SignUpForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorSolution.Framework
{
    public class TextBox : UIControl
    {
        private string content;

        public TextBox(DialogBox owner) : base(owner)  // slight changes added to framework
        {

        }

        public string GetContent()
        {
            return content;
        }

        public void SetContent(string content)
        {
            this.content = content;
            owner.Changed(this);
        }
    }
}
