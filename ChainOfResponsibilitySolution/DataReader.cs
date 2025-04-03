using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilitySolution
{
    public abstract class DataReader
    {
        private DataReader next;

        public void SetNext(DataReader next)
        {
            this.next = next;
        }
        public void Read(string fileName)
        {
            if (fileName.EndsWith(GetExtension()))
            {
                DoRead(fileName);
                return;
            }

            if (next != null)
            {
                next.Read(fileName);
            }
            else
            {
                throw new NotSupportedException("File format not supported.");
            }
        }

        protected abstract string GetExtension();
        protected abstract void DoRead(string fileName);
    }
}
