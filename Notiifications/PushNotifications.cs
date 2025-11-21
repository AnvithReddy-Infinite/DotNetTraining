using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notiifications
{
    public class PushNotification : INotification
    {
        public void Send(string to, string message)
        {
            Console.WriteLine($"Push notification sent to {to}: {message}");
        }
    }
}
