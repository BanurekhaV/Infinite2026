using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Day14
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // SimpleExpressions();
            ProductFilter.ExpressionswithFilter();
            Console.Read();
        }

        static void SimpleExpressions()
        {
            Expression<Func<int>> add = () => 2 + 2; //add is an expression

            var func = add.Compile();  // creates a delegate handler and assigns it to func
            var ans = func();  // invokes a delegate
            Console.WriteLine(ans);

            //eg 2.

            Expression<Func<int, bool>> expr = num => num < 5;

            //2. compile the above expression tree into a delegate
            Func<int, bool> result = expr.Compile();

            //3. invoke the delegate
            Console.WriteLine(result(40));

            //we can simplify the above 2 and 3 steps as below
            Console.WriteLine(expr.Compile()(4));

            Console.WriteLine("-----------Binary Expressions-----------");
            //eg 3. Binary expressions
            BinaryExpression be = Expression.Power(Expression.Constant(2d), Expression.Constant(3d));

            //create a lambda expression
            Expression<Func<double>> ble = Expression.Lambda<Func<double>>(be);

            //compile the lambda and return a delgate object 
            Func<double> CompiledExpr = ble.Compile();

            //invoke the delegate
            Console.WriteLine(CompiledExpr());
        }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

    }

    public class  ProductFilter
    {
        public Expression<Func<Product, bool>> FilterCriteria { get; set; }

        public static void ExpressionswithFilter()
        {
            var products = new List<Product>()
            {
                new Product { Id = 1, Name = "Pens", Price = 50 },
                new Product { Id = 2, Name = "Pencils", Price = 20 },
                new Product { Id = 3, Name = "USBs", Price = 350 },
                new Product { Id = 4, Name = "Memory Cards", Price = 500 },
            };

            var filter = new ProductFilter
            {
                FilterCriteria = p => p.Price < 100
            };

            var lesspricedProducts = products.AsQueryable().Where(filter.FilterCriteria).ToList();

            foreach (var p in lesspricedProducts)
            {
                Console.WriteLine(p.Name + " " + p.Price);
            }
        }

    }
}
