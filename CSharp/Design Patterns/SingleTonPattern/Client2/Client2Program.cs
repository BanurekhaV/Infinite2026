using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SingleTonPattern;

namespace Client2
{
    internal class Client2Program
    {
        static void Main(string[] args)
        {
            Singleton training = Singleton.GetInstance();
            training.PrintDetails("This is Dot Net Training Going on..");
            Console.Read();
        }
    }
}
