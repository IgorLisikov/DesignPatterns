using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodOld.Factory
{
    public abstract class ConnectionFactory  // creates single product
    {
        public abstract Connection GetConnection();
    }
}
