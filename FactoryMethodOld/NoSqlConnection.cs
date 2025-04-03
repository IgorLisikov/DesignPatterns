using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodOld
{
    public class NoSqlConnection : Connection
    {
        public override Connection GetConnection()
        {
            throw new NotImplementedException();
        }
    }
}
