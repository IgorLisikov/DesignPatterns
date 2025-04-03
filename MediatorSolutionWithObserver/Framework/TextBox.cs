using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorSolutionWithObserver.Framework
{
    public class TextBox : UIControl
    {
        private string content;
        public string GetContent()
        {
            return content;
        }

        public void SetContent(string content)
        {
            this.content = content;
            NotifyObservers();   // need to add slight changes to framework
        }
    }
}
