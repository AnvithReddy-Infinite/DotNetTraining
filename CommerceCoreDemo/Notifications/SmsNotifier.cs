using CommerceCoreDemo.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceCoreDemo.Notifications
{
    public class SmsNotifier : INotifier
    {
        public void Notify(string to, string message)
        {
            // In a real system, this would send an SMS.
            // For demo, just print to console.
            System.Console.WriteLine("[SMS to {0}]: {1}", to, message);
        }
    }
}
