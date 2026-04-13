using System;
using System.Collections.Generic;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;


namespace RemoteServices
{
    //service class
    public class RemoteServer : MarshalByRefObject
    {
        public int WriteMessage(int n1, int n2)
        {
            int maxval = (Math.Max(n1, n2));
            Console.WriteLine("Call Executed...");
            return maxval;
        }
        public string WelcomeMessage(string username)
        {
            return "Hello " + username + " " + "welcome to Remoting";
        }
    }
}
