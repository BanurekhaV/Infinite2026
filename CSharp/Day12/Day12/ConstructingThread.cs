using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Day12
{
    internal class ConstructingThread
    {
        static void Main()
        {
           //1.
                Thread t1 = new Thread(DisplayNumbers); //internally invokes a threadstart delegate 

            //2.
            Console.WriteLine("-------using threads--------");
            t1.Start();
            Thread.Sleep(1000);
            Console.WriteLine("---------------using thread delegate-----------");
            // 2.1 create a threadstart object and associate it with a function name of matching signature
            ThreadStart obj = new ThreadStart(DisplayNumbers);

            //we will pass threadstartdelegate object as an argument to the thread constructor
           //2.2
           Thread t2 = new Thread(obj);
           
            //2.3
            t2.Start();
            Console.Read();
        }

        static void DisplayNumbers()
        {
            for(int i=0; i<5; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
