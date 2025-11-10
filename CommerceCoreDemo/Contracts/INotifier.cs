using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceCoreDemo.Contracts
{
    public interface INotifier
    {
        void Notify(string to, string message);
    }

}
