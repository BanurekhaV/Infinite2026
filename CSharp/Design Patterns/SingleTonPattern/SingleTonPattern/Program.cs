using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTonPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton trainer = Singleton.GetInstance();
            trainer.PrintDetails("This is the Trainer ..");

            //creating another instance of singleton
            Singleton trainees = Singleton.GetInstance();
            trainees.PrintDetails("These are trainees ..");

            Singleton others = Singleton.GetInstance();
            others.PrintDetails("hello");

            //Singleton.derivedsingleton dobj = new Singleton.derivedsingleton();
            //dobj.PrintDetails("Hello derived");
            Console.Read();
        }
    }
}
