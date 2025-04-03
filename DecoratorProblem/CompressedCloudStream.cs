using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorProblem
{
    public class CompressedCloudStream : CloudStream  // add additional behaviour
    {
        new public void Write(string data)
        {
            var encrypted = Compress(data);
            base.Write(encrypted);
        }

        private string Compress(string data)
        {
            return data.Substring(0, 5);
        }
    }
}
