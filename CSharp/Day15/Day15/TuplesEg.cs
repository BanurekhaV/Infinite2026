using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15
{
    internal class TuplesEg
    {
        static void Main()
        {
            var values = new List<Double>() { 10, 20, 30, 40, 50 };

           //1. Tuple<int,double> t = Calculate(values);

           // Console.WriteLine($" There are {t.Item1} elements and their sum is {t.Item2}");
           //2.
            //var Result = Calculate(values);
            //Console.WriteLine($" There are {Result.Item1} elements and their sum is {Result.Item2}");
            
            //3.
            //var Result = Calculate(values);
           // Console.WriteLine($" There are {Result.count} elements and their sum is {Result.sum}");

           //4. 
           var(countres, sumres) = Calculate(values);
           Console.WriteLine($"There are {countres} elements and their sum is {sumres}");
          
            
            Console.Read();
        }

        //1.
       // static Tuple<int,double>Calculate (List<double> values)

        //2.
       // static (int,double) Calculate(List<Double> values) 
        
        //3 and 4
        static (int count, double sum)Calculate(List<Double> values) 
        {

            int count = 0;
            double sum = 0;

            foreach(var v in values)
            {
                count++;
                sum += v;
            }
            //creating another tuple object to return the values
           //1. Tuple<int,double>t1= Tuple.Create(count,sum);
           //1. return t1;

            //2 ,3 & 4
            return(count,sum);
        }


    }
}
