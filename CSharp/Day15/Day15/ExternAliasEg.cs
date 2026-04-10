extern alias X;
extern alias Y;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Lib1;
//using Lib2;

namespace Day15
{
    internal class ExternAliasEg
    {
        static void Main()
        {
            //Lib1.LibClass lc = new Lib1.LibClass();
            //lc.Message();
            //Lib2.LibClass lc2 = new Lib2.LibClass();
            //lc.Message();

            X.Lib1.LibClass lc = new X.Lib1.LibClass();
            lc._f = 5;
            lc.Message();

            Console.WriteLine("--------Local Functions-------");
            InnerFunctionEg();
            Console.WriteLine("-----Usecase of LocalFunctions------");
            Employee employee = new Employee()
            {
                Id = 1,
                Name = "Pavithra",
                Gender = "Female",
                Salary = 26500,
                Department = "IT"
            };

            bool IsInserted = InnerFunctionUsecase.AddEmployee(employee);
            Console.WriteLine("Is Employee inserted :? {0}", IsInserted);

            //Employee employee2 = new Employee()
            //{

            //};

            (string Name, double Sal, string Dept) = InnerFunctionUsecase.GetEmployeedDetails(1);
            Console.WriteLine(Name + " " + Sal +  " " + Dept);
            Console.Read();        
        }

        static void InnerFunctionEg()
        {
            int a = 10, b = 5, c = 10;
            int sum = Sum(a, b);  //calling a local function/inner function
            int diff = Difference(a,b);
            Console.WriteLine($"The sum of {a} and {b} is {sum}");
            Console.WriteLine($"The difference between {a} and {b} is {diff}");
            
            int Sum(int x, int y)
            {
                return c+= x + y;
            }

            int Difference(int x, int y)
            {
                return x - y;   
            }
            Console.WriteLine("Executed the local functions");
            Console.WriteLine("The new Sum is  "+ Sum(6,7));

        }
    }

    class InnerFunctionUsecase
    {

        public static (string name,double salary,string dept)GetEmployeedDetails(int eid)
        {
            Employee e = new Employee() { Name = "Banurekha", Salary = 45000, Department = "HR" };
            return (e.Name, e.Salary, e.Department);
        }
        //parent function
        public static bool AddEmployee(Employee request)
        {
            var validationResult = IsRequestValid();

            if (validationResult.isValid == false)
            {
                Console.Write($"{nameof(validationResult.errorMessage)} : {validationResult.errorMessage}");
                return false;
            }
            //some insertion code to the database
            return true;

            //local function

           (bool isValid, string errorMessage) IsRequestValid()
            {
                if(request == null)
                {
                    throw new ArgumentNullException(nameof(request), $"The {nameof(request)} cannot be null");
                }

                var lsb = new Lazy<StringBuilder>();
                if(String.IsNullOrEmpty(request.Name))
                {
                    lsb.Value.AppendLine($"The {nameof(request)}'s {nameof(request.Name)} Property cannot be null or empty");
                }
                if (String.IsNullOrEmpty(request.Gender))
                {
                    lsb.Value.AppendLine($"The {nameof(request)}'s {nameof(request.Gender)} Property cannot be null or empty");
                }
                if (String.IsNullOrEmpty(request.Department))
                {
                    lsb.Value.AppendLine($"The {nameof(request)}'s {nameof(request.Department)} Property cannot be null or empty");
                }
                if(request.Id<=0)
                {
                    lsb.Value.AppendLine($"The {nameof(request)}'s {nameof(request.Id)} Property cannot be less than or equal to zero");
                }
                if(request.Salary <=25000)
                {
                    lsb.Value.AppendLine($"The {nameof(request)}'s {nameof(request.Salary)} Property cannot be less than 25000/-");
                }

                if(lsb.IsValueCreated)
                {
                    var errMessage = lsb.Value.ToString();
                    return (isValid: false, errorMessage: errMessage);
                }
                return(isValid:true, errorMessage:string.Empty);
            }
        }
    }
}
