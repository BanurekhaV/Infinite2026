using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Day12
{
    class LockSync
    {
        public void DisplayNum()
        {
            lock (this)
            {
                for (int i = 0; i < 5; i++)
                {
                    Thread.Sleep(100);
                    Console.WriteLine("i = {0} and Thread name is {1}", i, Thread.CurrentThread.Name);
                }
            }
        }
    }
    internal class ThreadSyncEg
    {
        //join
        static void Main()
        {
            Thread t1 = new Thread(Func1);
            t1.Start();
            Thread t2 = new Thread(Func2);
            t2.Start();

            t2.Join();
            t1.Join();
            Console.WriteLine("-----------Locks----------");

            LockSync lobj = new LockSync();
            Console.WriteLine("Threading Using Locks");

            Thread th1 = new Thread(new ThreadStart(lobj.DisplayNum));
            th1.Name = "Thread first";
            Thread th2 = new Thread(new ThreadStart(lobj.DisplayNum));
            th2.Name = "Thread Second";
            th1.Start(); th2.Start();

            Console.Read();
        }

        static void Func1(object obj)
        {
            Console.WriteLine("Thread 1 executing..");
            Thread.Sleep(2000);
            Console.WriteLine("Thread 1 awake");
        }
        
        static void Func2(object obj)
        {
            Console.WriteLine("Thread 2 executing..");
            Thread.Sleep(1000);
            Console.WriteLine("Thread 2 awake");
        }
    }
}
