using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorProblem
{
    public class EncryptedCloudStream : CloudStream  // add additional behaviour
    {
        new public void Write(string data)
        {
            var encrypted = Encrypt(data);
            base.Write(encrypted);
        }

        private string Encrypt(string data)
        {
            return "%^*(&(*&&%&^$";
        }
    }
}
