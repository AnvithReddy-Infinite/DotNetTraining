using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notiifications
{
    public interface INotification
    {
        void Send(string to, string message);
    }
}
