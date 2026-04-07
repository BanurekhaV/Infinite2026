using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Day12
{
    internal class ThreadPoolEg
    {
        public static void nonPoolThreads()
        {
            //1. using threads
            for (int i = 0; i < 10; i++)
            {
                Thread thread = new Thread(MyMethod)
                {
                    Name = "Thread " + i
                };

                thread.Start();
            }
           
        }

        public static void MyMethod(object obj)
        {
            Thread thread = Thread.CurrentThread;
            string Message = $" Thread Name ? : {thread.Name}, Background ? : {thread.IsBackground}, Thread Pool ? :{thread.IsThreadPoolThread} ," +
                $" Thread Id ? : {thread.ManagedThreadId}";

            Console.WriteLine(Message);
            //}
        }

        public static void ThreadPoolThreads()
        {
            //2. Using ThreadPool

            for (int i = 0; i < 10; i++)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(MyMethod));
            }
            Console.Read();

        }

        static void Main()
        {
            nonPoolThreads();
            Console.WriteLine("---------using thread pools----------");
            ThreadPoolThreads();
            Console.Read();
        }
            
    }
}
