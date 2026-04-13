using System;
using System.Collections.Generic;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using RemoteServices;

namespace Server
{
    internal class ServerHost
    {
        static void Main(string[] args)
        {
            //create a channel
            HttpChannel httpChannel = new HttpChannel(88);

            //register the channel
            ChannelServices.RegisterChannel(httpChannel);

            //register services that will run on the channel
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServer),"OurRemoteServices",
                WellKnownObjectMode.SingleCall);
            Console.WriteLine("Remote Server Services Started at Port No 88........");
            Console.WriteLine("Press any key to Stop the server...");
            Console.Read();
        }
    }
}
