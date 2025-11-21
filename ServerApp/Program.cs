using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels.Tcp;
using RemotingLib;

namespace ServerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpChannel channel = new TcpChannel(8085);
            ChannelServices.RegisterChannel(channel, false);
            RemotingConfiguration.RegisterWellKnownServiceType(
                typeof(StudentService),
                "Studentservice",
                WellKnownObjectMode.Singleton);

            Console.WriteLine("Server started, listening on port 8085...");
            Console.ReadLine();
        }
    }

}











//public class ServerClass
//{
//    // make the class library public (host the library file)


//    public static void Main()
//    {//tcp is faster than http protocol
//     //all communcations happens in binary format
//     //disadvantages:It is not platform-independent
//     //http:advantages:it is platform dependent
//     //any client can make a request (java,python)
//     //all communication happen in Xml format.

//        TcpChannel channel = new TcpChannel(8085);
//        //HttpChannel for http protocol
//        ChannelServices.RegisterChannel(channel, false);
//        //channel means path/route.we are saying to server that pls use this path
//        //tcp route ,as it is tcp the comm happens in binary format.
//        RemotingConfiguration.RegisterWellKnownServiceType(
//            typeof(ServiceClass),
//            "Hi",
//            WellKnownObjectMode.Singleton);
//        Console.WriteLine("server started... Listening on port 8085");
//        Console.WriteLine("Press enter to stop");

//        Console.ReadLine();
//    }
//}