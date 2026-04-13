using System;
using System.Collections.Generic;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using RemoteServices;


namespace RemoteClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HttpChannel channel = new HttpChannel(8004);
            ChannelServices.RegisterChannel(channel);

            //create an object of the service class
            RemoteServer server = (RemoteServer)Activator.GetObject(typeof(RemoteServer),
                "http://localhost:88/OurRemoteServices");

            //start making calls remotely
            Console.WriteLine("The maximum number of the given 2 nos is : " + server.WriteMessage(23, 46));
            Console.WriteLine("Enter User Name :");
            string uname = Console.ReadLine();
            Console.WriteLine(server.WelcomeMessage(uname));
            Console.Read();

        }
    }
}
