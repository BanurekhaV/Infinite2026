using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    internal class AllGenerics<T> 
    {
        private T genericField;

        public T GenericProperty {  get; set; }

        public AllGenerics(T value)
        {
            this.genericField = value;
        }

        public T genericMethod(T genericParameter)
        {
            Console.WriteLine("Parameter Type : {0} and the value is {1}", typeof(T).ToString(),genericParameter);
            Console.WriteLine("Return Type : {0} and the values is {1}", typeof(T).ToString(),genericField);
            return genericField;
        }
    }
    class Tester
    {
        static void Main()
        {
            AllGenerics<int> intallgen = new AllGenerics<int>(10);
            Console.WriteLine(intallgen.genericMethod(100));
            intallgen.GenericProperty = 50; 
            Console.WriteLine(intallgen.GenericProperty);
            Console.WriteLine("++++++++++++++++++++++");

            AllGenerics<string> strallgen = new AllGenerics<string>("Hi Generics");
            Console.WriteLine(strallgen.genericMethod("String Parameter"));

            strallgen.GenericProperty = "String property";
            Console.WriteLine(strallgen.GenericProperty);
            Console.Read();
        }
    }
}
