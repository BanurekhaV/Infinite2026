using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Day12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // SimpleThread();
            //SingleThreads.Method1();
            //SingleThreads.Method2();
            //SingleThreads.Method3();
            Console.WriteLine("----------Working with MultiThreads-----------");
            Console.WriteLine("Main Thread Started...");
            Thread t1 = new Thread(MultiThreads.Method1) { Name = "Thread 1" };
            Thread t2 = new Thread(MultiThreads.Method2) { Name = "Thread 2" };
            Thread t3 = new Thread(MultiThreads.Method3) { Name = "Thread 3" };

            //executing the methods
            t1.Start();
            t2.Start();
            t3.Start();
            Console.WriteLine("Main Thread Concluded..");

            Console.Read();
        }

        static void SimpleThread()
        {
            Thread t = Thread.CurrentThread;
            t.Name = "Test";
            Console.WriteLine("Current Executing Thread : " + t.Name);
            Console.WriteLine("Current Executing Thread : " + Thread.CurrentThread.Name);
        }

        class SingleThreads
        {
            //drawbacks of single threaded application
           public static void Method1()
           {
                for(int i=0; i<=5; i++)
                {
                    Console.WriteLine("Method 1 : "+ i);
                }
           }
            public static void Method2()
            {
                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine("Method 2 : " + i);
                    if(i==3)
                    {
                        Console.WriteLine("Starting to perform database activity..");
                        //make the thread sleep for 10 second
                        Thread.Sleep(10000);
                        Console.WriteLine("Database activity completed....");
                    }
                }
            }
            public static void Method3()
            {
                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine("Method 3 : " + i);
                }
            }
        }

        class MultiThreads
        {
            //drawbacks of single threaded application
            public static void Method1()
            {
                Console.WriteLine("Method 1 started using " + Thread.CurrentThread.Name);
                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine("Method 1 : " + i);
                }
                Console.WriteLine("Method 1 ended using " + Thread.CurrentThread.Name);
            }
            public static void Method2()
            {
                Console.WriteLine("Method 2 started using : "+ Thread.CurrentThread.Name);
                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine("Method 2 : " + i);
                    if (i == 3)
                    {
                        Console.WriteLine("Starting to perform database activity..");
                        //make the thread sleep for 10 second
                        Thread.Sleep(10000);
                        Console.WriteLine("Database activity completed....");
                    }
                }
                Console.WriteLine("Method 2 ended using " + Thread.CurrentThread.Name);
            }
            public static void Method3()
            {
                Console.WriteLine("Method 3 started using " + Thread.CurrentThread.Name);
                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine("Method 3 : " + i);
                }
                Console.WriteLine("Method 3 ended using " + Thread.CurrentThread.Name);
            }
        }
    }
}
