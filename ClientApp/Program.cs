using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels.Tcp;
using RemotingTrn;

namespace ClientApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpChannel channel = new TcpChannel();
            ChannelServices.RegisterChannel(channel, false);

            IStudentService service = (IStudentService)Activator.GetObject(
                typeof(IStudentService),
                "tcp://localhost:8085/StudentSrvice");

            Console.WriteLine("Connected to remote StudentService...");

            Console.WriteLine(service.ShowAllStudents()); // Show all students

            Console.Write("Enter student ID to search: ");
            int id = int.Parse(Console.ReadLine());
            string result = service.GetStudentDetails(id);
            Console.WriteLine("Search result: " + result);

            Console.ReadLine();
        }
    }

}











//internal class Program
//{
//    static void Main(string[] args)
//    {
//        {// an application who wants to consume the service

//            TcpChannel channel = new TcpChannel();// i want to communicate using binary format
//                                                  //TcpChannel channel1 = channel;
//            ChannelServices.RegisterChannel(channel, false);// register the the path, no security

//            // Connect to remote object
//            IMyinter ob = (IMyinter)Activator.GetObject(
//                typeof(IMyinter),
//                "tcp://localhost:8085/Hi");

//            Console.WriteLine("Connected to remote object...");
//            Console.Write("Enter your name: ");
//            string name = Console.ReadLine();

//            string result = ob.Show(name);
//            Console.WriteLine(result);


//            Console.Read();

//        }
//    }
//}
