using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RemotingTrn;

namespace RemotingLib
{
    public class ServiceClass : MarshalByRefObject, IMyinter
    {
        public string Show(string name)
        {
            // MarshalByRefObject : represents the call can be called from remote system
            return $"Hello, {name}! How Are You!";
            
        }
    }
}
