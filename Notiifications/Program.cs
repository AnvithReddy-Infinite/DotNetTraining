using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notiifications
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter notification type (Email/Sms/Push): ");
            string nt = Console.ReadLine();
            Console.Write("Enter recipient: ");
            string to = Console.ReadLine();
            Console.Write("Enter message: ");
            string msg = Console.ReadLine();

            try
            {
                INotification notification = NotificationFactory.GetNotification(nt);
                notification.Send(to, msg);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
