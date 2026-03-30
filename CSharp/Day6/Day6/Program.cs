using System;
using static System.Console;
using static System.Convert;

namespace Day6
{    
    internal class Program
    {
        public static void GCOps()
        {
            Program program = new Program();
            WriteLine("The number of generations are : " + GC.MaxGeneration);
            WriteLine("The generation number of object program is " + GC.GetGeneration(program));
            WriteLine("total memory : " + GC.GetTotalMemory(false));
           
            GC.Collect();
            Console.WriteLine("Garbage collection in generation 0 is : " + GC.CollectionCount(0));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("First Statement");

            goto infinite;
            Console.WriteLine("Second Statement");
            Console.WriteLine("Thirsd Statement");

        infinite:
            Console.WriteLine("Infinite welcomes you all ....");

            goto label1;
            Console.WriteLine("Unreachable code..");

            label1:
            Console.WriteLine("Bye for now..");

            doagain:
            Console.WriteLine("Enter anumber less than 10");
            int num= ToInt32(ReadLine());
            if(num>=10)
            {
                Console.WriteLine("Number should be less than 10 only, reenter");
                goto doagain;
            }
            Console.WriteLine(num +  " is less than 10 only");
            Console.WriteLine("-----------Garbage Example---------");
            GCOps();
            WriteLine("=========== Dispose Example ===========");
            DisposeEg dobj = new DisposeEg();
            dobj.justlikethat();
          //  dobj.Dispose();  calling explicitly
            Read();
        }
        
    }

    //partial class example
   partial class Marks
   {
        public void sampleFunc()
        {
            WriteLine("Hi Partial");
        }
   } 
}
