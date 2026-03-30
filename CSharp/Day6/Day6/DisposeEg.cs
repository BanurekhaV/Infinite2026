using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class DisposeEg : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("DisposeEg Object is being disposed");
        }
       
        public void justlikethat()
        {
            using (DisposeEg dispobj = new DisposeEg())
            {
                Console.WriteLine("Created and allocated with memeory for disposeeg");
            }  // calls Dispose implicitly

        //    //Console.WriteLine("Hello");
        //    //DisposeEg disposeEg = new DisposeEg();
        //    //Console.WriteLine("Created an Object and alloted memory..");
        }       
    }
}
