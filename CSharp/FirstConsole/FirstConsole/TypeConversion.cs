using System;
using System.Runtime.CompilerServices;


namespace FirstConsole
{
    internal class TypeConversion
    {
        static void Main()
        {
            TypeConversion typeConversion = new TypeConversion();
           // typeConversion.Typechange();
            // typeConversion.Box_Unbox();
            // typeConversion.Try_ParseEg();
           // Others.Ternary_Func(); //invoking static function of other class
           // Others.NullConcept();
           Others others = new Others();
            int res = others.Addnos(50,20);
            Console.WriteLine(res);
            Console.Read();
        }

        public void Typechange()
        {
            Console.WriteLine("Minimum Value of integer {0} ", int.MinValue);
            Console.WriteLine("Maximum is {0} ", int.MaxValue);

            //declaring a primitive type
            int num = 100;
            Console.WriteLine("num is " + num);
            float f = num;    // implicit conversion
            Console.WriteLine("num is " + num);
            f = 2456.55f;
            Console.WriteLine("float is " + f);
            num = (int)f;    // explicit conversion using typecasting
            Console.WriteLine("float is " + num);
            num = Convert.ToInt32(f);  // explicit conversion using function
            Console.WriteLine("float is " + num);
        }

        public void Box_Unbox()
        {
            int i = 10;   //value type
            object obj;   //reference type
            obj = i;   //value type to reference type -- boxing
            string s = "AAAA";
            obj = s;  //implicit casting

            float salary;
            Console.WriteLine("Enter Salary");
            salary = float.Parse(Console.ReadLine());  //reference to value type --unboxing
            Console.WriteLine(salary);

            bool b;
            b=Convert.ToBoolean(Console.ReadLine()); //unboxing

            DateTime dt;
            dt= Convert.ToDateTime(Console.ReadLine()); //unboxing
        }

        public void Try_ParseEg()
        {
            string str = "1000";
            int result = 0;
            bool success = int.TryParse(str, out result);
            if (success)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }

    class Others
    {
        public static void Ternary_Func()
        {
            int num = 10;
            bool b;
            if(num == 10)
            {
                b = true;
            }
            else
            {
                b = false;
            }

            Console.WriteLine("Number == 10 ? {0}",b);
            Console.WriteLine("-------------------");
            b=num== 10? true:false;
            Console.WriteLine(b);           
        }

       public  static void NullConcept()
        {
            int? number1 = null;  // nullable value type
            int sum;
            //if(number1 == null)
            //{
            //    sum = 0;
            //}
            //else
            //{
            //    {
            //        sum = (int)number1;   //or
            //        sum= number1.Value;
            //    }
            //}
            //the above can be replaced with null coalescing operator
            sum = number1 ?? 50;
            Console.WriteLine("the value of sum is : " + sum);

            char ? c = null;
           // c = 'a';
            Console.WriteLine(c);

            float? empsalary = 50000;
            empsalary = empsalary ?? 20000;
            Console.WriteLine(empsalary);
        }

        public int Addnos(int a, int b) 
        {
            return a + b;
        }
    }
}
