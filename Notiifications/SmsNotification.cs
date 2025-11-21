using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notiifications
{
    public class SmsNotification : INotification
    {
        public void Send(string to, string message)
        {
            Console.WriteLine($"SMS sent to {to}: {message}");
        }
    }
}
