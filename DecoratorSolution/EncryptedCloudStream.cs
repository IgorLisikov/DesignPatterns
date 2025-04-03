using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorSolution
{
    public class EncryptedCloudStream : IStream  // Composition over inheritance
    {
        private IStream stream;

        public EncryptedCloudStream(IStream stream)
        {
            this.stream = stream;
        }

        public void Write(string data)
        {
            var encrypted = Encrypt(data);
            stream.Write(encrypted);
        }

        private string Encrypt(string data)
        {
            return "%^*(&(*&&%&^$";
        }
    }
}
