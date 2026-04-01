using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
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
            Console.WriteLine("---------------Generic Indexers--------------");
            GenericIndexers<float> genfloat = new GenericIndexers<float>();
            genfloat.Name = "Jayavardhini";
            genfloat.Var1 = 125.45f;
            genfloat[0] = 5.5f;
            genfloat[1] = 10.5f;
            genfloat[2] = 15.5f;
            Console.WriteLine(genfloat[0] + " " + genfloat[1] +" " + genfloat[2]);

            genfloat[0.0f] =25.5f;
            genfloat[1.0f] = 30.5f;
            genfloat[2.0f] = 35.5f;
            Console.WriteLine(genfloat[0.0f] + " " + genfloat[1.0f] + " " + genfloat[2.0f]);
            Console.Read();
        }
    }

    class GenericIndexers<T>
    {
        private T[] data = new T[3];
        private T var1;
        private string name;

        public string Name
        {
            get { return name; } set { name = value; }
        }

        public T Var1
        {
            get { return var1; }
            set { var1 = value; }
        }

        //indexer 1
        public T this[int index]
        {
            get { return data[index]; }
            set { data[index] = value; }
        }
        //indexer 2
        public T this[float index]
        {
            get { return data[(int)index]; }
            set { data[(int)index] = value; }
        }

        //indexer 3
        public T this[string index]
        {
            get { return data[Convert.ToInt32(index)]; }
            set { data[Convert.ToInt32(index)] = value; }
        }
    }
}
