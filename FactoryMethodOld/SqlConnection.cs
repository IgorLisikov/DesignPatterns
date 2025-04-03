using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodOld
{
    public class SqlConnection : Connection
    {
        public override Connection GetConnection()
        {
            throw new NotImplementedException();
        }
    }
}
