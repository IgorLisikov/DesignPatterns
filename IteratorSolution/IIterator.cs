using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorSolution
{
    public interface IIterator<T>
    {
        T Current();
        bool HasNext();
        void MoveNext();
    }
}
