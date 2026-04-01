using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    internal class Generics1<T>
    {
        //generic fields
        private T data;

        //generic property for the field
        public T Data
        {
            get { return this.data; }
            set { this.data = value; }
        }

        //generic method
        public void Display<T>(string msg, T var1)
        {
            Console.WriteLine("{0} : {1}", msg, var1);
        }
    }

    class TestGeneric
    {
        static void Main()
        {
            Generics1<string> refObj = new Generics1<string>();
            refObj.Data = "Infinite Ltd.";
            Console.WriteLine(refObj.Data);
          
            refObj.Display<int>("Integer", 15);
            refObj.Display<string>("String", "Hello World");
            refObj.Display<Char>("Character", 'A');
            Console.WriteLine("-----------------");

            Generics1<float> genfloat = new Generics1<float>();
            genfloat.Data = 5.5f;
            Console.WriteLine(genfloat.Data);
            Console.Read();
        }
    }
}
