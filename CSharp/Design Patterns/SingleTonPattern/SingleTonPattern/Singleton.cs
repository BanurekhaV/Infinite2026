using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTonPattern
{
    public sealed class Singleton
    {
        private static int Counter = 0;

        private static Singleton instance = null;

        //the below returns a singleton instance
        public static Singleton GetInstance()
        {
            if(instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }

        //private constructor
        private Singleton()
        {
            Counter++;
            Console.WriteLine("Counters Value is : " + Counter.ToString());
        }

        //normal method
        public void PrintDetails(string message)
        {
            Console.WriteLine(message); 
        }

        //innerclass
        //public class derivedsingleton : Singleton
        //{

        //}
    }

    
}
